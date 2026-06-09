using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class DoorTeleport : MonoBehaviour
{
    public  string      targetScene;
    public  string      targetSpawnPoint;
    public  AudioClip   sound;
    private AudioSource audioSource;

    void Awake()
    {
        // Busca o AudioSource neste mesmo objeto
        audioSource = GetComponent<AudioSource>();
        
        // Opcional: Se esquecer de adicionar o componente, o Unity adiciona sozinho para não dar erro
        if (audioSource == null) {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")) {
            StartCoroutine(ChangeScene());  // Mantem a dinamica do jogo enquanto executa ChangeScene
        }
    }

    IEnumerator ChangeScene()
    {
        if(audioSource != null)  {
            audioSource.Stop();
            if(sound != null){
                // Play o som da porta
                audioSource.clip = sound;
                audioSource.loop = false;
                audioSource.Play();
                yield return new WaitForSeconds(audioSource.clip.length);
            }
        }
        // Move o Player para a nova sena, e para a posição definida
        SceneData.spawnPointName = targetSpawnPoint;
        SceneManager.LoadScene(targetScene);
    }
}