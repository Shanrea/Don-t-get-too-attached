using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Slider))]
public class GameManager : MonoBehaviour

{
    public Text GoblinText;
    public Text OrcText;
    public Text OgreText;
    private Slider selfSlider;
    int GoblinAmount = 0;



    // Start is called before the first frame update
    void Start()
    {
        selfSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick ()
    {
        //Score.text = (int.Parse(Score.text)+1).ToString();  //Incrémente le score et le retransforme en string

        
    }

    public void SliderIncrement()
    {
        selfSlider.value = selfSlider.value + 1; //Incrémente la valeur du slider
        if (selfSlider.value == 20) //Si on atteint le max (20), on gagne un Goblin et le slider repasse à 0.
        {
            GoblinAmount++;
            GoblinText.text = "x " + GoblinAmount.ToString();
            selfSlider.value = 0;
        }
    }
}
