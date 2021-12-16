using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class CardSlider : MonoBehaviour
{
    private Slider selfSlider;
    int GoblinAmount = 0;
    private Text QuantiteMonstre;

    // Start is called before the first frame update
    void Start()
    {
        selfSlider = GetComponent<Slider>();
        QuantiteMonstre = this.transform.Find("QuantiteMonstre").GetComponent<Text>();
    }
    public void SliderIncrement()
    {
        Debug.Log(QuantiteMonstre);
        selfSlider.value = selfSlider.value+1; //Incr�mente la valeur du slider
        if (selfSlider.value == 4) //Si on atteint le max (20), on gagne un Goblin et le slider repasse � 0. !!!A REMETTRE A 20!!!
        {
            GoblinAmount++;
            selfSlider.value = 0;
            QuantiteMonstre.text = GoblinAmount.ToString();
        }

    }
}
