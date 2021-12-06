using System.Collections;
using System.Collections.Generic;
using Gameplay.ShipControllers;
using Gameplay.ShipSystems;
using UnityEngine;

//namespace Gameplay.ShipControllers.CustomControllers
//{
    public class PlayerShipController : ShipController
    {
        protected override void ProcessHandling(MovementSystem movementSystem)
        {
            movementSystem.LateralMovement(Input.GetAxis("Horizontal") * Time.deltaTime);
            //movementSystem.LongitudinalMovement(Input.GetAxis("Vertical") * Time.deltaTime);
        }

        protected override void ProcessFire(WeaponSystem fireSystem)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                fireSystem.TriggerFire();
            }
        }

    }
//}
