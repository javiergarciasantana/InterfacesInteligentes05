//-----------------------------------------------------------------------
// <copyright file="ZombieController.cs" company="Google LLC">
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections;
using UnityEngine;

/// <summary>
/// Controls target object's behavior.
/// </summary>
public class ZombieController : MonoBehaviour
{
    public Material InactiveMaterial;
    public Material GazedAtMaterial;
    public Transform playerCamera;
    public float speed;
    private const float _minObjectDistance = 2.5f;
    private const float _maxObjectDistance = 3.5f;
    private const float _minObjectHeight = 0.5f;
    private const float _maxObjectHeight = 3.5f;

    public Transform[] spawnPoints;
    private Rigidbody rb;

    /// <summary>
    /// Start is called before the first frame update.
    /// </summary>
    public void Start()
    {
        // Ensure the camera is assigned
        if (playerCamera == null)
        {
            Debug.LogError("PlayerCamera is not assigned. Please assign the main camera in the inspector.");
            return;
        }

        // Set initial position
       // _startingPosition = transform.parent.localPosition;
        
        rb = GetComponent<Rigidbody>();

        // Check if the renderer and rigidbody are assigned correctly

        if (rb == null)
        {
            Debug.LogError("Rigidbody component is missing from the Zombie object.");
        }

        // Check if spawnPoints array is assigned and has elements
        if (spawnPoints == null || spawnPoints.Length == 0)
        {
            Debug.LogError("SpawnPoints array is empty. Assign spawn points in the Inspector.");
        }

        SetMaterial(false); // Set initial material to inactive
    }

    void Update()
    {
        // If playerCamera, _myRenderer, and rb are not assigned, return early
        if (playerCamera == null || rb == null) return;

        // Move zombie towards the camera
        Vector3 direction = (playerCamera.position - transform.position).normalized;
        rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
    }

    /// <summary>
    /// This method is called by the Main Camera when it starts gazing at this GameObject.
    /// </summary>
    public void OnPointerEnter()
    {
        SetMaterial(true);
    }

    /// <summary>
    /// This method is called by the Main Camera when it stops gazing at this GameObject.
    /// </summary>
    public void OnPointerExit()
    {
        SetMaterial(false);
    }

    /// <summary>
    /// Sets this instance's material according to gazedAt status.
    /// </summary>
    /// <param name="gazedAt">True if this object is being gazed at, false otherwise.</param>
    private void SetMaterial(bool gazedAt)
    {

        if (gazedAt)
        {
            
            // Ensure spawnPoints array has elements before accessing
            if (spawnPoints != null && spawnPoints.Length > 0)
            {
                transform.position = spawnPoints[0].position;
            }
        }
    }
}
