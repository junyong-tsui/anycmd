﻿
namespace Anycmd.Engine.Ac.Messages.Rbac
{
    using InOuts;

    public class UpdateSsdSetCommand: UpdateEntityCommand<ISsdSetUpdateIo>, IAnycmdCommand
    {
        public UpdateSsdSetCommand(IAcSession acSession, ISsdSetUpdateIo input)
            : base(acSession, input)
        {

        }
    }
}