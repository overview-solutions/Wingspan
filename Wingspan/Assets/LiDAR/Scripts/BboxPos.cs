using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoudiniEngineUnity;

public class BboxPos : MonoBehaviour
{
    public GameObject target;
    public GameObject hdaObject;

    private HEU_HoudiniAsset hdaAsset;
    private HEU_ParameterData boxPositionParameter;

    void Start()
    {
        hdaAsset = hdaObject.GetComponent<HEU_HoudiniAsset>();
        if (hdaAsset == null)
        {
            Debug.LogError("No se encontró el componente HEU_HoudiniAsset en el objeto hdaObject. Por favor, asegúrate de seleccionar el objeto correcto.");
        }
        else
        {
            boxPositionParameter = hdaAsset.Parameters.GetParameter("Box_Position");
            if (boxPositionParameter == null)
            {
                Debug.LogError("No se encontró el parámetro 'Box_Position'. Asegúrate de que el nombre del parámetro esté escrito correctamente en el HDA.");
            }
        }
    }

    void Update()
    {
      /* if (hdaAsset != null && boxPositionParameter != null)
        {
            Vector3 targetPosition = target.transform.position;
            hdaAsset.Parameters.SetParameterValue(boxPositionParameter, targetPosition, true);
            hdaAsset.RequestCook(true, true, true, true);
        } 
     */
    }
}
