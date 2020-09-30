﻿using System;
using AutoPoco.Engine;

namespace AutoPoco.Actions
{
    public class ObjectMethodInvokeFuncAction<TPoco, TReturn> : IObjectAction
    {
        private Func<TPoco, TReturn> mAction;

        public ObjectMethodInvokeFuncAction(Func<TPoco, TReturn> action)
        {
            mAction = action;
        }

        public void Enact(IGenerationContext context, object target)
        {
            mAction.Invoke((TPoco)target);
        }
    }
}
