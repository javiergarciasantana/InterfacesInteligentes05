//-----------------------------------------------------------------------
// <copyright file="CoinController.cs" company="Google LLC">
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

using UnityEngine;
using UnityEngine.UI; // Ensure you include this

public class CoinController : MonoBehaviour
{

    public Text scoreText;    
    public Vector3 minRange;       // Minimum teleport range (x, y, z)
    public Vector3 maxRange;       // Maximum teleport range (x, y, z)

    private int score = 0;

    private void Start()
    {
        UpdateScoreText();         // Initialize the score display
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    public void TeleportRandomly(bool isGAzedAt)
    {
      if (isGAzedAt) {
          // Generate a random position within the specified range
          float randomX = Random.Range(minRange.x, maxRange.x);
          float randomY = Random.Range(minRange.y, maxRange.y);
          float randomZ = Random.Range(minRange.z, maxRange.z);
          transform.position = new Vector3(randomX, randomY, randomZ);
          
          // Increase score and update score display
          score += 10;
          UpdateScoreText();
      }

    }

    public void OnPointerEnter()
    {
        TeleportRandomly(true);
    }

    public void OnPointerExit()
    {
        TeleportRandomly(false);
    }

}
