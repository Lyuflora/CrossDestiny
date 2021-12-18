using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject m_Map;
    public Text[] DialogTexts;

    public Font EngFont;
    public Font ChnFont;

    private void Awake()
    {
        Animator animator = m_Map.GetComponent<Animator>();
        animator.SetBool("isOpen", false);
    }
    void Start()
    {
        Animator animator = m_Map.GetComponent<Animator>();
        animator.SetBool("isOpen", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            OpenPanel(m_Map, "isOpen");
        }
    }

    void OpenPanel(GameObject Panel, string varName)
    {
        Animator animator = Panel.GetComponent<Animator>();
        if (animator)
        {
            bool isOpen = animator.GetBool(varName);
            animator.SetBool(varName, !isOpen);
        }
    }

    public void SetEngFonts()
    {
        for(int i=0;i< DialogTexts.Length; i++)
        {
            DialogTexts[i].font = EngFont;
            DialogTexts[i].fontSize = 40;
        }
            
    }
    public void SetChnFonts()
    {
        for (int i = 0; i < DialogTexts.Length; i++)
        {
            DialogTexts[i].font = ChnFont;
            DialogTexts[i].fontSize = 38;
        }
            
    }
}
