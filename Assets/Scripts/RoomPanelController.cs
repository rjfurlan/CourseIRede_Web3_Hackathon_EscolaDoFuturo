using UnityEngine;

/* Esta classe tem como objetivo gerenciar as mudanças de seleçao dos componente
   os componentes ao receberem uma interação, via
        função:     Interact
        da classe:  PanelSelectable
    chamam a função SelectItem desta classe.

    Obs.: Num refactore desta classe e da PanelSelectable
          algumas funções que estão na PanelSelectable.Highlight deverão vir para a SelectItem
          Assim a Highlight só vai receber a informação de seu estado
          e a rotina de mudar os demais e colocar o objeto correto ficará aqui
*/
public class RoomPanelController : MonoBehaviour
{
    private AudioSource audioSource;

    void Awake() {
        // Busca o AudioSource neste mesmo objeto
        audioSource = GetComponent<AudioSource>();
        
        // Se esquecer de adicionar o componente, o Unity adiciona sozinho para não dar erro
        if (audioSource == null) {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }


    public void SelectItem(PanelSelectable item) {
        item.Highlight();   // Melhoria: tirar o Highlight do item e colocar aqui

        if(audioSource != null)  {
            audioSource.Stop();
            if(item.sound != null){
                audioSource.clip   = item.sound;
                audioSource.loop   = true;
                audioSource.Play();
            }
        }
    }
}