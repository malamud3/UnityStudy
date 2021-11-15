using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class Player : MonoBehaviour
{

    private bool _isDead = false;
    public bool isDead
    {
        get { return _isDead; }
        protected set { _isDead = value; }
    }

    private  int maxHealth = 100;

   
    private int currentHealth;

    public int kills;
    public int deaths;


    [SerializeField]
    private GameObject deathEffect;

    [SerializeField]
    private GameObject spawnEffect;

    private bool firstSetup = true;

    private WeaponManager weaponManager;


    public Player()
    {

        isDead = false;

        currentHealth = maxHealth;
       
        //Enable the components
        //   for (int i = 0; i < disableOnDeath.Length; i++)
        //    {
        //       disableOnDeath[i].enabled = wasEnabled[i];
        //   }

        //Enable the gameobjects
        //     for (int i = 0; i < disableGameObjectsOnDeath.Length; i++)
        //     {
        //         disableGameObjectsOnDeath[i].SetActive(true);
        //      }

        //Enable the collider
        //     Collider _col = GetComponent<Collider>();
        //     if (_col != null)
        //      _col.enabled = true;

        //Create spawn effect
        ///  GameObject _gfxIns = (GameObject)Instantiate(spawnEffect, transform.position, Quaternion.identity);
        //  Destroy(_gfxIns, 3f);
    }

    public void TakeDamage(int _amount, string _sourceID)
    {
        if (isDead)
            return;

        currentHealth -= _amount;

        Debug.Log(transform.name + " now has " + currentHealth + " health.");

        if (currentHealth <= 0)
        {
            Die(_sourceID);
        }
    }

    private void Die(string _sourceID)
    {
        isDead = true;

        Player sourcePlayer = GameManager.GetPlayer(_sourceID);

        Debug.Log("die");
        /**
        if (sourcePlayer != null)
        {
            sourcePlayer.kills++;
        }

        deaths++;

        //Disable components
        for (int i = 0; i < disableOnDeath.Length; i++)
        {
            disableOnDeath[i].enabled = false;
        }

        //Disable GameObjects
        for (int i = 0; i < disableGameObjectsOnDeath.Length; i++)
        {
            disableGameObjectsOnDeath[i].SetActive(false);
        }

        //Disable the collider
        Collider _col = GetComponent<Collider>();
        if (_col != null)
            _col.enabled = false;

        //Spawn a death effect
        GameObject _gfxIns = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(_gfxIns, 3f);
    **/
        
     //   }

        Debug.Log(transform.name + " is DEAD!");

    }

    ///   private IEnumerator Respawn()
    //   {
    //   yield return new WaitForSeconds(gameManager.instance.matchSettings.respawnTime);

    //     Transform _spawnPoint = NetworkManager.singleton.GetStartPosition();
    //    transform.position = _spawnPoint.position;
    //   transform.rotation = _spawnPoint.rotation;

    //    yield return new WaitForSeconds(0.1f);

    //     SetupPlayer();

    //    Debug.Log(transform.name + " respawned.");
    //  }

}
    