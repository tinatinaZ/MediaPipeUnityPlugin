using UnityEngine;

namespace HandLandmarkInterface
{
    public class HandTransformLink : MonoBehaviour
    {
        public Transform Target;

        public void UpdateTransform()
        {
            if (Target == null)
                return;
            Target.position = this.transform.position;
            Target.rotation = this.transform.rotation;
        }
    }

}