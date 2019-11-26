using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tower : MonoBehaviour
{
    private Vector3 _currentPosition = new Vector3();

    public int numberOfPinOnTheBotomLayer = 4;
    public GameObject pin;
    public GameObject parent;

    private float _pinSpacingY;
    private float _pinSpacingZ;


    // Start is called before the first frame update
    void Start()
    {
        if (!parent.activeSelf) return;

        var scales = pin.transform.localScale;
        _pinSpacingY = scales.y * 2;
        _pinSpacingZ = scales.z + scales.z / 5;
        for (var i = 0; i < numberOfPinOnTheBotomLayer; i++) 
        {
            
            _currentPosition = new Vector3(0,
                scales.y + _pinSpacingY * i,
                0- (_pinSpacingZ * (numberOfPinOnTheBotomLayer - i)) / 2);

                for (var j = 0; j < numberOfPinOnTheBotomLayer - i; j++)
                {
                     pin.transform.position = _currentPosition;
                     Instantiate(pin, parent.transform);
                    _currentPosition += new Vector3(0, 0, _pinSpacingZ);
                
                }

        }
    }
    
}
