using UnityEngine;

// Musica de fundo para a sena
public class SceneMusicManager : MonoBehaviour
{
    public  AudioClip   backgroundMusic;
    private AudioSource audioSource;

    void Awake() {
        // Busca o AudioSource neste mesmo objeto
        audioSource = GetComponent<AudioSource>();
        
        // Opcional: Se esquecer de adicionar o componente, o Unity adiciona sozinho para não dar erro
        if (audioSource == null) {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void Start() {
        if (audioSource != null && backgroundMusic != null)
        {
            audioSource.clip = backgroundMusic;
            audioSource.loop = true;         // Mantém a música repetindo
            audioSource.playOnAwake = false; // Controlamos o play manualmente abaixo
            audioSource.Play();
        }
    }
}
