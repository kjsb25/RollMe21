using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class EntityCreator : MonoBehaviour {
    public Entity curEntity;
    public Canvas EntityCanvas;

    private Text Str, Dex, Con, Int, Wis, Chr, AC, Init, Spd, TotHP, CurHP;
	// Use this for initialization
	void Start () {

       


    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.H))
        {
            EntityCanvas.enabled = !EntityCanvas.enabled;
        }
      
	}

    public void updateOverlay()
    {
        Str = GameObject.FindGameObjectWithTag("Str").GetComponent(typeof(Text)) as Text;
        Dex = GameObject.FindGameObjectWithTag("Dex").GetComponent(typeof(Text)) as Text;
        Con = GameObject.FindGameObjectWithTag("Con").GetComponent(typeof(Text)) as Text;
        Int = GameObject.FindGameObjectWithTag("Int").GetComponent(typeof(Text)) as Text;
        Wis = GameObject.FindGameObjectWithTag("Wis").GetComponent(typeof(Text)) as Text;
        Chr = GameObject.FindGameObjectWithTag("Chr").GetComponent(typeof(Text)) as Text;



        AC = GameObject.FindGameObjectWithTag("AC").GetComponent(typeof(Text)) as Text;
        Init = GameObject.FindGameObjectWithTag("Init").GetComponent(typeof(Text)) as Text;
        Spd = GameObject.FindGameObjectWithTag("Spd").GetComponent(typeof(Text)) as Text;


        TotHP = GameObject.FindGameObjectWithTag("TotHP").GetComponent(typeof(Text)) as Text;
        CurHP = GameObject.FindGameObjectWithTag("CurHP").GetComponent(typeof(Text)) as Text;


        Str.text = curEntity.attributes.Strength.ToString();
        Dex.text = curEntity.attributes.Dexterity.ToString();
        Con.text = curEntity.attributes.Constitution.ToString();
        Int.text = curEntity.attributes.Intelligence.ToString();
        Wis.text = curEntity.attributes.Wisdom.ToString();
        Chr.text = curEntity.attributes.Charisma.ToString();


        AC.text = curEntity.attributes.AC.ToString();
        Init.text = curEntity.attributes.Initiative.ToString();
        Spd.text = curEntity.attributes.Speed.ToString();


        TotHP.text = curEntity.totHP.ToString();
        CurHP.text = curEntity.curHP.ToString();


    }
}
