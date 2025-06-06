﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel.Primitives;
#if SOURCE_GENERATOR
using System.ClientModel.SourceGeneration.Tests;
#endif
using System.ClientModel.Tests.Client.Models.ResourceManager.Compute;
using System.Collections.Generic;

namespace System.ClientModel.Tests.ModelReaderWriterTests.Models.AvailabilitySetDatas
{
    public partial class ListTests : MrwCollectionTests<List<AvailabilitySetData>, AvailabilitySetData>
    {
        protected override string CollectionTypeName => "List<AvailabilitySetData>";

#if SOURCE_GENERATOR
        protected override ModelReaderWriterContext Context => BasicContext.Default;
#else
        protected override ModelReaderWriterContext Context => new LocalContext();
#endif

        protected override List<AvailabilitySetData> GetModelInstance()
        {
            return [ModelInstances.s_testAs_3375, ModelInstances.s_testAs_3376];
        }

        protected override void CompareModels(AvailabilitySetData model, AvailabilitySetData model2, string format)
            => AvailabilitySetDataTests.CompareAvailabilitySetData(model, model2, format);
    }
}
