using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehindInFront : MonoBehaviour
{
    
    
        public Transform youTrans;
        public Transform enemyTrans;
        
        void Update()
        {
            //Your forward vector
            Vector3 youForward = youTrans.forward;
            /*print(youForward);*/
            //The vector from you to the enemy (Vector3)
            Vector3 youToEnemy = enemyTrans.position - youTrans.position;
            //float that always shows the distance between two vectors3
            var youToEnemyAlternative = Vector3.Distance(enemyTrans.position, youTrans.position);
            //In this case characters are always facing the same way and it will be the same if they are behind each other or not 
           
            
            //Now we need to figure out if these vectors are pointing in the opposite direction, if so
            //the enemy is behind you. To do that we will use the dot product
            //Unity's built in version:
            float dotProductUnity = Vector3.Dot(youForward, youToEnemy);
            //Our own version, which is the same:
            
            float dotProduct = Vector3.Dot(youForward.normalized, youToEnemy.normalized);
            print(dotProduct);

            //For normalized vectors the dot product returns: 
            // 1 if they point in exactly the same direction, 
            //-1 if they point in completely opposite directions 
            // 0 if the vectors are perpendicular
            //But normalization takes some computer time, so you can ignore it if you are just interested
            //in knowing if the enemy is behind you and your field-of-view is 90 degrees
            //Otherwise you have to normalize the vectors and define "in front" as something like > 0.5
            
            if (dotProduct >0f)
            {
                Debug.Log("In front");
            } else if (dotProduct == 0f)
            {
                print("alligned");
            }
            else
            {
                Debug.Log("Behind");
            }
        }

        float DotProduct(Vector3 vec1, Vector3 vec2)
        {
            float dotProduct = vec1.x * vec2.x + vec1.y * vec2.y + vec1.z * vec2.z;

            return dotProduct;
        }
}
