using Mediapipe;
using System.Collections.Generic;
using UnityEngine;

namespace HandLandmarkInterface
{
    public class HandLandmarkResultSet : MonoBehaviour
    {
        public bool Connected;
        public Vector3 DeviceOrientation { get; set; }

        private NormalizedLandmarkList leftHandLandmarks;
        public NormalizedLandmarkList LeftHandLandmarks
        {
            get => leftHandLandmarks;
            set
            {
                leftHandLandmarks = value;
            }
        }

        private NormalizedLandmarkList rightHandLandmarks;

        public NormalizedLandmarkList RightHandLandmarks
        {
            get => rightHandLandmarks;
            set
            {
                rightHandLandmarks = value;
            }
        }


        public void UpdateLandmark(HandLandmarkType landmarkType, NormalizedLandmarkList landmarkList)
        {
            if (landmarkType == HandLandmarkType.LeftHand)
            {
                LeftHandLandmarks = landmarkList;
                //Debug.Log($"left hand: {landmarkList.Landmark[0].X}, {landmarkList.Landmark[0].Y}, {landmarkList.Landmark[0].Z}");
            }
            else if (landmarkType == HandLandmarkType.RightHand)
            {
                RightHandLandmarks = landmarkList;
                //Debug.Log($"right hand: {landmarkList.Landmark[0].X}, {landmarkList.Landmark[0].Y}, {landmarkList.Landmark[0].Z}");
            }
            else
            {
                Debug.LogError("Not Implemented");
            }
        }

        public List<Vector3> GetLandmarks(HandLandmarkType landmarkType)
        {
            if (landmarkType == HandLandmarkType.LeftHand)
            {
                return LeftHandLandmarks != null ? LeftHandLandmarks.ToList() : null;
            }
            else if (landmarkType == HandLandmarkType.RightHand)
            {
                return RightHandLandmarks != null ? RightHandLandmarks.ToList() : null;
            }

            return null;
        }

    }

}