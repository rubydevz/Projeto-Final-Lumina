using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ativar : MonoBehaviour
{
    public GameObject platformToDestroy;
    public GameObject objectToDeactivate;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print("botão apertado");
            Destroy(gameObject);
            print("botão destruido");            
            if (platformToDestroy != null)
            {
                Destroy(platformToDestroy);
                print("plataforma destruida"); 
            }
            if (objectToDeactivate != null)
            {
                StartCoroutine(DeactivateAndActivate(objectToDeactivate, 5f));
            }
        }
    }
    private IEnumerator DeactivateAndActivate(GameObject obj, float delay)
    {
        print("desativado)");
        obj.SetActive(false); 
        yield return new WaitForSeconds(delay);
        print("ativado");
        obj.SetActive(true);
        Debug.Log($"{obj.name} ativado novamente após {delay} segundos.");
    }
}