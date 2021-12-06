using UnityEngine;

namespace Gameplay.Helpers
{
    public static class GameAreaHelper
    {
        public static float _leftBound;
        public static float _rightBound;
        private static Camera _camera;
        

        static GameAreaHelper()
        {
            _camera = Camera.main;
        }

        
        //возвращает тру если внутри границ
        public static bool IsInGameplayArea(Transform objectTransform, Bounds objectBounds)
        {
            var camHalfHeight = _camera.orthographicSize;
            var camHalfWidth = camHalfHeight * _camera.aspect;
            var camPos = _camera.transform.position;
            var topBound = camPos.y + camHalfHeight;
            var bottomBound = camPos.y - camHalfHeight;
            var leftBound = camPos.x - camHalfWidth;
            _leftBound = leftBound;
            var rightBound = camPos.x + camHalfWidth;
            _rightBound = rightBound;

            var objectPos = objectTransform.position;
            return (objectPos.x - objectBounds.extents.x < rightBound)
                && (objectPos.x + objectBounds.extents.x > leftBound)
                && (objectPos.y - objectBounds.extents.y < topBound)
                && (objectPos.y + objectBounds.extents.y > bottomBound);

        }
        
    }
}
