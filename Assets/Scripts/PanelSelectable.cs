using UnityEngine;



public class PanelSelectable : MonoBehaviour, IInteractable
{
    public RoomPanelController controller;
    public GameObject          prefab;
    public AudioClip           sound;

    public Color normalColor   = Color.white;
    public Color selectedColor = Color.yellow;

    private Renderer            cubeRenderer;

    void Start() {
        cubeRenderer = GetComponent<Renderer>();
    }

    public void Interact() {
        controller.SelectItem(this);
    }

    // veja nota no inicio da classe: RoomPanelController
    public void Highlight() {
        PanelSelectable[] items =  FindObjectsOfType<PanelSelectable>();

        foreach(var item in items){
            if (item.cubeRenderer != null) {
                item.cubeRenderer.material.color = item.normalColor;
            }

            // Desativa o objeto/prefab dos outros cubos
            if (item.prefab != null) {
                item.prefab.SetActive(false);
            }
            
        }

        // 2. Aplica a cor de seleção no cubo atual
        if (cubeRenderer != null) {
            cubeRenderer.material.color = selectedColor;
        }

        // 3. ATIVA o objeto/prefab deste cubo selecionado
        if (prefab != null) {
            prefab.SetActive(true);
        }
    }
}