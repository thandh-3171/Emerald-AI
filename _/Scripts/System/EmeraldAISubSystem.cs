using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EmeraldAI
{
    public class EmeraldAISubSystem : MonoBehaviour
    {
        #region private vars
        EmeraldAISystem mainSystem;
        #endregion

        #region mono
        private void Awake()
        {
            SetComponents();
        }
        #endregion

        #region private methods
        private void SetComponents()
        {
            if (mainSystem == null) mainSystem = GetComponentInParent<EmeraldAISystem>();
        }
        #endregion

        #region observable methods
        void EmeraldAttackEvent()
        {
            mainSystem.EmeraldAttackEvent();
        }
        #endregion
    }
}