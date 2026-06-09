using UnityEngine;
using UnityEngine.SceneManagement;

// Necessario ter o Character controler no player
public class MouseAsJoystickNavigation : MonoBehaviour {
    public  float angMinCamera  =   20f;
    public  float angMaxCamera  =   90f;
    public  float mouseDeadZone = 0.15f;
    public  float speedMove     =   10f;
    public  float speedRotation =   90f;
    public  float speedZoom     =   20f;
    
    private bool                buttonRightPressed  = false;
    private bool                buttonCenterPressed = false;
    private float               screenWidthDiv2;
    private float               screenHeightDiv2;
    private float               xRotation           = 0f;
    private Camera              playerCamera;
    private CharacterController controller;
    private Vector3             mousePosRef;    


    public static MouseAsJoystickNavigation Instance;

    void Awake() {
        // caso retorne a sena que já tenha um player, destroi o player
        // para evitar a duplicidade de players, mantendo só original
        if(Instance != null && Instance != this) {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);  // Permite que player para a outra 
    }

    // roda sempre que o objeto acorda e fica ativo.
    void OnEnable() {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // roda obrigatoriamente antes do objeto ser destruído 
    // garante a remoção do OnSceneLoaded quando o objeto é destruido 
    // evitando travamentos/vazamentos de memoria
    void OnDisable() {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    // Quando a cena é carregado coloca o player na posição esperada/definida
    void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
        GameObject spawn = GameObject.Find(SceneData.spawnPointName);

        if(spawn != null)
        {
            Debug.Log("Player OnSceneLoaded 3");
            transform.position = spawn.transform.position;
            transform.rotation = spawn.transform.rotation;

            Debug.Log("Player movido para SpawnPoint");
        }
    }
    
    void Start() {
        playerCamera     = Camera.main; // para pegar direto a camera sem prescisar arrastar na IDE
        controller       = GetComponent<CharacterController>(); // Necessario ter o Character controler no player
        
        // centro da tela
        screenWidthDiv2  = Screen.width  * 0.5f;
        screenHeightDiv2 = Screen.height * 0.5f;
    }
    void Update(){
        if (Input.GetMouseButton(1)) {  // Botão direito clicado, gera movimentos
            if(buttonRightPressed){
                // Com a posição de referencia já registrada executa o movimento
                Move();
            }else{
                // ao prescionar o botão registra a posição como referencia para os movimentos
                mousePosRef        = Input.mousePosition;
                buttonRightPressed = true;
            }
            buttonCenterPressed = false;
            return;
        } else {
            buttonRightPressed = false;
        };
        
        // Só trata o botão Central se o botão da direita estiver solto
        if (Input.GetMouseButton(2)) {  // Botão Central clicado gera rotação
            if(buttonCenterPressed){
                // Com a posição de referencia já registrada executa a rotação
                Rotate();
            }else{
                // ao prescionar o botão registra a posição como referencia para as rotações
                mousePosRef         = Input.mousePosition;
                buttonCenterPressed = true;
            }
            return;
        } else{
            buttonCenterPressed = false;
        }
        
        if (Input.GetMouseButton(0)) {  // Botão Esquerdo clicado gera Interação
            Interact();
            return;
        }
        
        // Se nenhum botão clicado, avalia se deve fazer zoom, angulo de visão da camera
        Zoom();        
    }
    
    void Move() {
        Vector3 mousePos = Input.mousePosition;
        
        float offsetX    = mousePos.x - mousePosRef.x;
        float offsetY    = mousePos.y - mousePosRef.y;
        
        // Normaliza entre -1 e 1
        float moveX      = offsetX / screenWidthDiv2;
        float moveY      = offsetY / screenHeightDiv2;
        
        // Verifica se o mouse está na dead zone, região sem movimento
        if (Mathf.Abs(moveX) < mouseDeadZone) moveX = 0;
        if (Mathf.Abs(moveY) < mouseDeadZone) moveY = 0;
        
        Vector3 move = (transform.right * moveX) + (transform.forward * moveY);
        move.y = 0;
        
        controller.Move(move * speedMove * Time.deltaTime);
    }
    
    void Rotate() {
        Vector3 mousePos = Input.mousePosition;
        
        float offsetX    = mousePos.x - mousePosRef.x;
        float offsetY    = mousePos.y - mousePosRef.y;
        
        // Normaliza entre -1 e 1
        float moveX      = offsetX / screenWidthDiv2;
        float moveY      = offsetY / screenHeightDiv2;
        
        // Verifica se o mouse está na dead zone
        if (Mathf.Abs(moveX) < mouseDeadZone) moveX = 0;
        if (Mathf.Abs(moveY) < mouseDeadZone) moveY = 0;
        
        moveX *= speedRotation * Time.deltaTime;
        moveY *= speedRotation * Time.deltaTime;
        
        xRotation = Mathf.Clamp(xRotation - moveY, -90f, 90f);
        playerCamera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        transform.Rotate(Vector3.up * moveX);        
    }
    
    // Trata interações do mouse com objetos,
    // quando o botão esquerdo do mouse é clicado em cima do objeto
    void Interact() {       
        Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        /*if (Physics.Raycast(ray, out hit)) {
            Debug.Log("Objeto clicado: " + hit.collider.name );
        }*/

        // captura o objeto clicado
        if (Physics.Raycast(ray, out hit)) {
            // Para debugar o objeto clicado
            //Debug.Log("Objeto clicado: " + hit.collider.name );

            // captura o interactable do objeto
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();

            // se o objeto possuir interactable executa
            if(interactable != null) {
                Debug.Log("Objeto clicado Interagindo");
                interactable.Interact();
            }
        }
    }

    // muda o campo de visão da camera dentro de um limite minimo e máximo
    void Zoom() {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        
        playerCamera.fieldOfView = Mathf.Clamp(
            playerCamera.fieldOfView - scroll * speedZoom,
            angMinCamera, angMaxCamera);
    }
}