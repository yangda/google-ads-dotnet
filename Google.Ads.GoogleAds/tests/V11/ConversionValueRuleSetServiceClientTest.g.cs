// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gagve = Google.Ads.GoogleAds.V11.Enums;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V11.Services;

namespace Google.Ads.GoogleAds.Tests.V11.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedConversionValueRuleSetServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void MutateConversionValueRuleSetsRequestObject()
        {
            moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient> mockGrpcClient = new moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient>(moq::MockBehavior.Strict);
            MutateConversionValueRuleSetsRequest request = new MutateConversionValueRuleSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionValueRuleSetOperation(),
                },
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
                PartialFailure = false,
            };
            MutateConversionValueRuleSetsResponse expectedResponse = new MutateConversionValueRuleSetsResponse
            {
                Results =
                {
                    new MutateConversionValueRuleSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateConversionValueRuleSets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionValueRuleSetServiceClient client = new ConversionValueRuleSetServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateConversionValueRuleSetsResponse response = client.MutateConversionValueRuleSets(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateConversionValueRuleSetsRequestObjectAsync()
        {
            moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient> mockGrpcClient = new moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient>(moq::MockBehavior.Strict);
            MutateConversionValueRuleSetsRequest request = new MutateConversionValueRuleSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionValueRuleSetOperation(),
                },
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
                PartialFailure = false,
            };
            MutateConversionValueRuleSetsResponse expectedResponse = new MutateConversionValueRuleSetsResponse
            {
                Results =
                {
                    new MutateConversionValueRuleSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateConversionValueRuleSetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateConversionValueRuleSetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionValueRuleSetServiceClient client = new ConversionValueRuleSetServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateConversionValueRuleSetsResponse responseCallSettings = await client.MutateConversionValueRuleSetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateConversionValueRuleSetsResponse responseCancellationToken = await client.MutateConversionValueRuleSetsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void MutateConversionValueRuleSets()
        {
            moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient> mockGrpcClient = new moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient>(moq::MockBehavior.Strict);
            MutateConversionValueRuleSetsRequest request = new MutateConversionValueRuleSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionValueRuleSetOperation(),
                },
            };
            MutateConversionValueRuleSetsResponse expectedResponse = new MutateConversionValueRuleSetsResponse
            {
                Results =
                {
                    new MutateConversionValueRuleSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateConversionValueRuleSets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionValueRuleSetServiceClient client = new ConversionValueRuleSetServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateConversionValueRuleSetsResponse response = client.MutateConversionValueRuleSets(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateConversionValueRuleSetsAsync()
        {
            moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient> mockGrpcClient = new moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient>(moq::MockBehavior.Strict);
            MutateConversionValueRuleSetsRequest request = new MutateConversionValueRuleSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionValueRuleSetOperation(),
                },
            };
            MutateConversionValueRuleSetsResponse expectedResponse = new MutateConversionValueRuleSetsResponse
            {
                Results =
                {
                    new MutateConversionValueRuleSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateConversionValueRuleSetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateConversionValueRuleSetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionValueRuleSetServiceClient client = new ConversionValueRuleSetServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateConversionValueRuleSetsResponse responseCallSettings = await client.MutateConversionValueRuleSetsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateConversionValueRuleSetsResponse responseCancellationToken = await client.MutateConversionValueRuleSetsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
