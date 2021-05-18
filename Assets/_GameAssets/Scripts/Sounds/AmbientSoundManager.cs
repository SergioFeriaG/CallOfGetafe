using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider), typeof(AudioSource))]
public class AmbientSoundManager : MonoBehaviour
{    
    [SerializeField]
    [Range(0,10)]
    [Tooltip("Duración de la atenuación en segundos")]
    float fadeTime;//Tiempo de duración de la atenuación

    private float initialVolume;//Volumen inicial
    private float delta;
    private float fadePause;//Tiempo de espera entre incrementos/decrementos de volumen
    private AudioSource audioSource;

    public static class FadeAudioSource {

        public static IEnumerator StartFade(AudioSource audioSource, float duration, float targetVolume) {
            float currentTime = 0;
            float start = audioSource.volume;

            while (currentTime < duration) {
                    currentTime += Time.deltaTime;
                    audioSource.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
                    yield return null;
                }   
            yield break;
            }
        }

    private void Awake() {
        audioSource = GetComponent<AudioSource>();
        initialVolume = audioSource.volume;
        delta = initialVolume / 100f;
        fadePause = fadeTime / 100f;
        audioSource.volume=0;
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")){
            PlaySound();
        }
    }
    private void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player")){
            StopSound();
        }
    }
    void PlaySound(){
        StopAllCoroutines();
        if (!audioSource.isPlaying){
            audioSource.Play();
        }
        StartCoroutine(FadeAudioSource.StartFade(audioSource, 2, 0.5f));
    }
    void StopSound() {
        StopAllCoroutines();
        StartCoroutine(FadeAudioSource.StartFade(audioSource, 2, 0));
    }
    /*IEnumerator FadeIn() 
    {
        for(int i=0;i<100;i++) {
            audioSource.volume+=delta;
            audioSource.volume=Mathf.Min(audioSource.volume, initialVolume);
            yield return new WaitForSeconds(fadeTime/100);
        }
        audioSource.volume = initialVolume;
    }
    IEnumerator FadeOut() 
    {
        for(int i=0;i<100;i++) {
            audioSource.volume-=delta;
            audioSource.volume=Mathf.Max(audioSource.volume, 0);
            yield return new WaitForSeconds(fadeTime/100);
        }
        audioSource.volume = 0;
        audioSource.Stop();
    }*/
}
