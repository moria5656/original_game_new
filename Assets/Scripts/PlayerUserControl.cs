using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class PlayerUserControl : MonoBehaviour
{
    private CharacterController m_Character;
    float h;
    float v;

    public int thisPlayerID;

    
    private void Awake()
    {
        m_Character = GetComponent<CharacterController>();
    }
    

    private void FixedUpdate()
    {
        
        if(thisPlayerID == 1)
        {
            h = CrossPlatformInputManager.GetAxis("Horizontal_P1");
            v = CrossPlatformInputManager.GetAxis("Vertical_P1");
        }
        else if (thisPlayerID == 2)
        {
            h = CrossPlatformInputManager.GetAxis("Horizontal_P2");
            v = CrossPlatformInputManager.GetAxis("Vertical_P2");
        }
        else
        {
            h = CrossPlatformInputManager.GetAxis("Horizontal");
            v = CrossPlatformInputManager.GetAxis("Vertical");
        }

        m_Character.Move(h, v, v, 0f);
    }
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
