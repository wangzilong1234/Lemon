﻿
using UnityEngine;
using Lemon.SkillSystem;

namespace Lemon
{
    public sealed class MainManager : UIBaseBehavior
    {
        public static float deltaTime;

        protected override void MonoStart()
        {
            UIMgr.Instance.Init();
            LanguageManager.Instance.Initial();
            SkillSystemManager.Instance.Initial();
        }

        protected override void MonoUpdate()
        {
            deltaTime += Time.deltaTime;
            SkillSystemManager.Instance.onUpdate();
        }
    }
}
