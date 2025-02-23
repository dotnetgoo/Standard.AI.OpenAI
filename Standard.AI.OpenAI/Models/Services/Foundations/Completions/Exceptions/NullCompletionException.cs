﻿// --------------------------------------------------------------- 
// Copyright (c) Coalition of the Good-Hearted Engineers 
// ---------------------------------------------------------------

using Xeptions;

namespace Standard.AI.OpenAI.Models.Services.Foundations.Completions.Exceptions
{
    public class NullCompletionException : Xeption
    {
        public NullCompletionException()
            : base(message: "Completion is null.") { }
    }
}
