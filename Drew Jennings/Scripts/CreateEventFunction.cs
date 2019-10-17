﻿/* By: Ryan Scheppler
 * Date: 10/9/19
 * Description: Add to objects meant to create things on unity events
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEventFunction : MonoBehaviour
{
    public GameObject ObjectToMake;


    //function can be run to create given object
    public void CreateObject()
    {
        Instantiate(ObjectToMake, transform.position, transform.rotation);
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(ObjectToMake, transform.position, transform.rotation);
    }
}
