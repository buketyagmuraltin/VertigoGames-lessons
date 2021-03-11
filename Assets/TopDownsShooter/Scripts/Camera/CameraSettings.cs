using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Camera
{
    [CreateAssetMenu(menuName = "Topdown Shooter/Camera/Camera Settings")]
    public class CameraSettings : ScriptableObject
    {
        [Header("Position")]
        [SerializeField] private float _rotationLerpSpeed = 3;
        public float RotationLerpSpeed { get { return _rotationLerpSpeed;} }

        [Header("Position")]
        [SerializeField] private Vector3 _positionOffSet;
        public Vector3 PositionOffSet { get { return _positionOffSet; } }

        [SerializeField] private float _positionLerp = 1;
        public float PositionLerp { get { return _positionLerp; } }




    }
}