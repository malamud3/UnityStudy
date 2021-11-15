using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{

    [SerializeField]
    public  Transform weaponHolder;

    [SerializeField]
    public  Weapon currentWeapon;

    private  WeaponGraphics currentGraphics;

    public void  EquipWeapon(Weapon _weapon)
    {
        currentWeapon = _weapon;

        GameObject _weaponIns = (GameObject)Instantiate(_weapon.graphics, weaponHolder.position, weaponHolder.rotation);
        _weaponIns.transform.SetParent(weaponHolder);

        currentGraphics = _weaponIns.GetComponent<WeaponGraphics>();
        if (currentGraphics == null)
            Debug.LogError("No WeaponGraphics component on the weapon object: " + _weaponIns.name);

     
    }


    public WeaponGraphics GetCurrentGraphics()
    {
        return currentGraphics;
    }

    public void setCurrentGraphics(GameObject muzzleFlash, GameObject hitEffectPrefab)

    {
        currentGraphics.muzzleFlash = muzzleFlash;
        currentGraphics.hitEffectPrefab= hitEffectPrefab;
    }

    public Weapon GetCurrentWeapon()
    {
        return currentWeapon;
    }  
}