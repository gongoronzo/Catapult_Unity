using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Canvas : MonoBehaviour
{

    public Text textIndicador;
    public Text textJugador;
    public Indicador indicador;
    public Jugador jugadorPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        textIndicador.text = indicador.potencia.ToString() + "   " + indicador.angulo.ToString();
        textJugador.text = "Mover: " + jugadorPrefab.Mover.ToString();

    }
}
