using UnityEngine;

[RequireComponent(typeof(WeaponManager))]
public class PlayerShoot : MonoBehaviour
{


    [SerializeField]
    private Camera cam;

    [SerializeField]
    private LayerMask mask;

    private Weapon currentWeapon;
    WeaponManager weaponManager;

    public GameObject muzzleFlash;
    public GameObject hitEffectPrefab;

    bool makeSureNoBug = true;

    void Start()
    {
        if (cam == null)
        {
            Debug.LogError("PlayerShoot: No camera referenced!");
            this.enabled = false;
        }
        GameManager.AddPlayers();
        Debug.Log("Number of Players:" + GameManager.players.Count);
    }

    void Update()
    {
             
             if (Input.GetButtonDown("Fire1") && makeSureNoBug == true)
            {
                weaponManager = GetComponent<WeaponManager>();
                currentWeapon = weaponManager.GetCurrentWeapon();
                Shoot();
            }
        



        // a shoot effect

        void OnShoot()
        {
            GameObject _hitEffect = (GameObject)Instantiate(muzzleFlash, transform.position, transform.rotation);
            Destroy(_hitEffect, 2f);
        }

        //Takes in the hit point and the normal of the surface

        void OnHit(Vector3 _pos, Vector3 _normal)
        {
            DoHitEffect(_pos, _normal);
        }

        //Do Effect 2f  then Destroy
        void DoHitEffect(Vector3 _pos, Vector3 _normal)
        {
            GameObject _hitEffect = (GameObject)Instantiate(hitEffectPrefab, _pos, Quaternion.LookRotation(_normal));
            Destroy(_hitEffect, 2f);
        }


        void Shoot()
        {

            OnShoot();
            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out RaycastHit _hit, currentWeapon.range, mask))
            {
                Debug.Log(_hit.collider.name);

                if (_hit.collider.name.Contains("Player"))
                {
                    PlayerShot(_hit.collider.name, currentWeapon.damage, transform.name);
                }

                // We hit something, call the OnHit method on the server
                OnHit(_hit.point, _hit.normal);
            }


        }

        void PlayerShot(string _playerID, int _damage, string _sourceID)
        {
            Debug.Log(_playerID + " has been shot.");

            Player _player = GameManager.GetPlayer(_playerID);
            _player.TakeDamage(_damage, _sourceID);
        }

    }
}
