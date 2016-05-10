// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.IO;
using System.Text;
using Xunit;

using Test.Cryptography;

namespace System.Security.Cryptography.Pkcs.Tests
{
    internal static class Certificates
    {
        public static readonly CertLoader RSAKeyTransfer1 = new CertLoaderFromRawData(RawData.s_RSAKeyTransfer1Cer, RawData.s_RSAKeyTransfer1Pfx, "1111");
        public static readonly CertLoader RSAKeyTransfer2 = new CertLoaderFromRawData(RawData.s_RSAKeyTransfer2Cer, RawData.s_RSAKeyTransfer2Pfx, "1111");
        public static readonly CertLoader RSAKeyTransfer3 = new CertLoaderFromRawData(RawData.s_RSAKeyTransfer3Cer, RawData.s_RSAKeyTransfer3Pfx, "1111");
        public static readonly CertLoader RSAKeyTransferCapi1 = new CertLoaderFromRawData(RawData.s_RSAKeyTransferCapi1Cer, RawData.s_RSAKeyTransferCapi1Pfx, "1111");
        public static readonly CertLoader RSASha256KeyTransfer1 = new CertLoaderFromRawData(RawData.s_RSASha256KeyTransfer1Cer, RawData.s_RSASha256KeyTransfer1Pfx, "1111");
        public static readonly CertLoader RSASha384KeyTransfer1 = new CertLoaderFromRawData(RawData.s_RSASha384KeyTransfer1Cer, RawData.s_RSASha384KeyTransfer1Pfx, "1111");
        public static readonly CertLoader RSASha512KeyTransfer1 = new CertLoaderFromRawData(RawData.s_RSASha512KeyTransfer1Cer, RawData.s_RSASha512KeyTransfer1Pfx, "1111");
        public static readonly CertLoader DHKeyAgree1 = new CertLoaderFromRawData(RawData.s_DHKeyAgree1Cer);

        // Note: the raw data is its own (nested) class to avoid problems with static field initialization ordering.
        private static class RawData
        {
            public static byte[] s_RSAKeyTransfer1Cer =
                 ("308201c830820131a003020102021031d935fb63e8cfab48a0bf7b397b67c0300d06092a864886f70d0101050500301a3118"
                + "30160603550403130f5253414b65795472616e7366657231301e170d3136303431323136323534375a170d31373034313232"
                + "32323534375a301a311830160603550403130f5253414b65795472616e736665723130819f300d06092a864886f70d010101"
                + "050003818d00308189028181009eaab63f5629db5ac0bd74300b43ba61f49189ccc30c001fa96bd3b139f45732cd3c37e422"
                + "ccbb2c598a4c6b3977a516a36ff850a5e914331f7445e86973f5a6cbb590105e933306e240eab6db72d08430cd7316e99481"
                + "a272adef0f2479d0b7c58e89e072364d660fdad1b51a603ff4549a82e8dc914df82bcc6c6c232985450203010001a30f300d"
                + "300b0603551d0f040403020520300d06092a864886f70d01010505000381810048c83e6f45d73a111c67e8f9f9c2d646292b"
                + "75cec52ef0f9ae3e1639504aa1759512c46527fcf5476897d3fb6fc515ff1646f8f8bc09f84ea6e2ad04242d3fb9b190b816"
                + "86b73d334e8b3afa7fb8eb31483efc0c7ccb0f8c1ca94d8be4f0daade4498501d02e6f92dd7b2f4401550896eb511ef14417"
                + "cbb5a1b360d67998d334").HexToByteArray();

            // password = "1111"
            public static byte[] s_RSAKeyTransfer1Pfx =
                 ("308205d20201033082058e06092a864886f70d010701a082057f0482057b308205773082034806092a864886f70d010701a0"
                + "82033904820335308203313082032d060b2a864886f70d010c0a0102a08202a6308202a2301c060a2a864886f70d010c0103"
                + "300e040818fdedadbb31b101020207d0048202806aa390fa9a4cb071a0daf25765ed69efe039896036c0f0edfc03ebe35d2a"
                + "f2f6a5bc9efd907f3b64ae15ac7f61d830e48810aa096ee37fe442b7bfbceeb92e22c25bd5484baf91460be29e06648485db"
                + "7b10ea92d17983c4d22067396c12e4598541ab989d7beb38bf8a0213fd7c9d49ecd46d319bbb58b1423504cd4145e1b33978"
                + "41306c5ace9eab42d408e05101911adc684e63a8c8c9579ce929e48ce2393af1a63c3180c52bd87475e3edb9763dff731ede"
                + "38fc8043dee375001a59e7d6eec5d686d509efee38ef0e7bddcd7ba0477f6f38ff7172ceaeef94ff56ad4b9533241f404d58"
                + "c2b5d54f1ab8250c56b1a70f57b7fffc640b7037408b8f830263befc031ffe7dbc6bef23f02c1e6e2b541be12009bfb11297"
                + "02fc0559e54d264df9b0d046c73ad1b25056231e5d3c4015bdc4f0a9af70ac28b7241233ecc845ce14484779102a45da2560"
                + "c354ec3e01f26d0e0b9a8b650f811d2ffeba95ec1e5cf6be2d060788c1b18ea4ec8f41e46da734c1216044a10a3e171620ed"
                + "79f7e9dd36972c89d91111c68fd60a94d2aa2a3dbbde0383c7c367f77b70a218ddf9fb4ed7abf94c233ffb2797d9ca3802ed"
                + "77868d3ab5651abb90e4de9ea74854b13603859b308689d770a62b5821e5a5650ecb23ca2894ad7901c7e1d2f22ef97e9092"
                + "f0791e886487a59d380d98c0368d3f2f261e0139714b02010e61aa073ee782b1fe5b6f79d070ef1412a13270138330a2e308"
                + "599e1e7829be9f983202ac0dc1c38d38587defe2741903af35227e4f979a68adef86a8459be4a2d74e5de7f94e114a8ea7e4"
                + "0ea2af6b8a93a747377bdd8ddd83c086bb20ca49854efb931ee689b319f984e5377f5a0f20d0a613326d749af00675c6bc06"
                + "0be528ef90ec6a9b2f9b3174301306092a864886f70d0109153106040401000000305d06092b060104018237110131501e4e"
                + "004d006900630072006f0073006f0066007400200053006f0066007400770061007200650020004b00650079002000530074"
                + "006f0072006100670065002000500072006f007600690064006500723082022706092a864886f70d010701a0820218048202"
                + "14308202103082020c060b2a864886f70d010c0a0103a08201e4308201e0060a2a864886f70d01091601a08201d0048201cc"
                + "308201c830820131a003020102021031d935fb63e8cfab48a0bf7b397b67c0300d06092a864886f70d0101050500301a3118"
                + "30160603550403130f5253414b65795472616e7366657231301e170d3136303431323136323534375a170d31373034313232"
                + "32323534375a301a311830160603550403130f5253414b65795472616e736665723130819f300d06092a864886f70d010101"
                + "050003818d00308189028181009eaab63f5629db5ac0bd74300b43ba61f49189ccc30c001fa96bd3b139f45732cd3c37e422"
                + "ccbb2c598a4c6b3977a516a36ff850a5e914331f7445e86973f5a6cbb590105e933306e240eab6db72d08430cd7316e99481"
                + "a272adef0f2479d0b7c58e89e072364d660fdad1b51a603ff4549a82e8dc914df82bcc6c6c232985450203010001a30f300d"
                + "300b0603551d0f040403020520300d06092a864886f70d01010505000381810048c83e6f45d73a111c67e8f9f9c2d646292b"
                + "75cec52ef0f9ae3e1639504aa1759512c46527fcf5476897d3fb6fc515ff1646f8f8bc09f84ea6e2ad04242d3fb9b190b816"
                + "86b73d334e8b3afa7fb8eb31483efc0c7ccb0f8c1ca94d8be4f0daade4498501d02e6f92dd7b2f4401550896eb511ef14417"
                + "cbb5a1b360d67998d3343115301306092a864886f70d0109153106040401000000303b301f300706052b0e03021a0414c4c0"
                + "4e0c0b0a20e50d58cb5ce565ba7c192d5d3f041479b53fc5f1f1f493a02cf113d563a247462e8726020207d0").HexToByteArray();

            public static byte[] s_RSAKeyTransfer2Cer =
                 ("308201c830820131a00302010202102bce9f9ece39f98044f0cd2faa9a14e7300d06092a864886f70d0101050500301a3118"
                + "30160603550403130f5253414b65795472616e7366657232301e170d3136303332353231323334325a170d31373033323630"
                + "33323334325a301a311830160603550403130f5253414b65795472616e736665723230819f300d06092a864886f70d010101"
                + "050003818d0030818902818100ea5a3834bfb863ae481b696ea7010ba4492557a160a102b3b4d11c120a7128f20b656ebbd2"
                + "4b426f1a6d40be0a55ca1b53ebdca202d258eebb20d5c662819182e64539360461dd3b5dda4085f10250fc5249cf023976b8"
                + "db2bc5f5e628fdb0f26e1b11e83202cbcfc9750efd6bb4511e6211372b60a97adb984779fdae21ce070203010001a30f300d"
                + "300b0603551d0f040403020520300d06092a864886f70d0101050500038181004dc6f9fd6054ae0361d28d2d781be590fa8f"
                + "5685fedfc947e315db12a4c47e220601e8c810e84a39b05b7a89f87425a06c0202ad48b3f2713109f5815e6b5d61732dac45"
                + "41da152963e700a6f37faf7678f084a9fb4fe88f7b2cbc6cdeb0b9fdcc6a8a16843e7bc281a71dc6eb8bbc4092d299bf7599"
                + "a3492c99c9a3acf41b29").HexToByteArray();

            // password = "1111"
            public static byte[] s_RSAKeyTransfer2Pfx =
                 ("308205d20201033082058e06092a864886f70d010701a082057f0482057b308205773082034806092a864886f70d010701a0"
                + "82033904820335308203313082032d060b2a864886f70d010c0a0102a08202a6308202a2301c060a2a864886f70d010c0103"
                + "300e04080338620310d29656020207d0048202804a94d3b1a1bf43efe3726aa9f0abc90c44585d2f0aee0864b4d574cd2cc1"
                + "dca4a353b102779e072ed6072d3c083b83974e74069b353ba8ac8be113228e0225993f5ecb7293ab1a6941bef75f7bcb0e3b"
                + "e6902832be46b976e94c6a0bc6865822ff07371551d206e300558da67cf972d89c3d181beb86d02f5523baa8351b88992654"
                + "a4c507e136dd32120530585a25424fe40f9962b910e08fb55f582c3764946ba7f6d92520decfc9faa2d5e180f9824e5ed4c8"
                + "c57e549a27950e7a875f2ed450035a69de6d95ec7bd9e30b65b8563fdd52809a4a1fc960f75c817c72f98afb000e8a8a33be"
                + "f62e458c2db97b464121489bf3c54de45e05f9c3e06c21892735e3f2d9353a71febcd6a73a0af3c3fc0922ea71bdc483ed7e"
                + "5653740c107cfd5e101e1609c20061f864671ccb45c8b5b5b7b48436797afe19de99b5027faf4cead0fd69d1987bbda5a0a4"
                + "0141495998d368d3a4747fc370205eed9fc28e530d2975ca4084c297a544441cf46c39fb1f0f42c65b99a6c9c970746012ad"
                + "c2be15fbbc803d5243f73fdec50bdee0b74297bd30ca3ea3a1dc623db6a199e93e02053bd1a6ca1a00a5c6090de1fa10cdd5"
                + "b5541bd5f5f92ff60a139c50deff8768e7b242018611efd2cce0d9441f3c8b207906345a985617ba5e98e7883c9b925ba17d"
                + "c4fadddbbe025cecd24bb9b95cae573a8a24ceb635eb9f663e74b0084a88f4e8e0d2baf767be3abe5b873695989a0edac7bd"
                + "092de79c3b6427dcbedee0512918fc3f7a45cd6898701673c9ed9f2f873abb8aa64cec7b8d350e8c780c645e50ce607a1afd"
                + "bcefba6cf5cebbc766d1e61d78fbef7680b38dd0f32133ceb39c6c9cabd0b33af9f7ef73c94854b57cf68e61997b61393a0b"
                + "6fc37f8834157e0c9fba3174301306092a864886f70d0109153106040401000000305d06092b060104018237110131501e4e"
                + "004d006900630072006f0073006f0066007400200053006f0066007400770061007200650020004b00650079002000530074"
                + "006f0072006100670065002000500072006f007600690064006500723082022706092a864886f70d010701a0820218048202"
                + "14308202103082020c060b2a864886f70d010c0a0103a08201e4308201e0060a2a864886f70d01091601a08201d0048201cc"
                + "308201c830820131a00302010202102bce9f9ece39f98044f0cd2faa9a14e7300d06092a864886f70d0101050500301a3118"
                + "30160603550403130f5253414b65795472616e7366657232301e170d3136303332353231323334325a170d31373033323630"
                + "33323334325a301a311830160603550403130f5253414b65795472616e736665723230819f300d06092a864886f70d010101"
                + "050003818d0030818902818100ea5a3834bfb863ae481b696ea7010ba4492557a160a102b3b4d11c120a7128f20b656ebbd2"
                + "4b426f1a6d40be0a55ca1b53ebdca202d258eebb20d5c662819182e64539360461dd3b5dda4085f10250fc5249cf023976b8"
                + "db2bc5f5e628fdb0f26e1b11e83202cbcfc9750efd6bb4511e6211372b60a97adb984779fdae21ce070203010001a30f300d"
                + "300b0603551d0f040403020520300d06092a864886f70d0101050500038181004dc6f9fd6054ae0361d28d2d781be590fa8f"
                + "5685fedfc947e315db12a4c47e220601e8c810e84a39b05b7a89f87425a06c0202ad48b3f2713109f5815e6b5d61732dac45"
                + "41da152963e700a6f37faf7678f084a9fb4fe88f7b2cbc6cdeb0b9fdcc6a8a16843e7bc281a71dc6eb8bbc4092d299bf7599"
                + "a3492c99c9a3acf41b293115301306092a864886f70d0109153106040401000000303b301f300706052b0e03021a04143cdb"
                + "6a36dfd2288ba4e3771766d7a5289c04419704146c84193dc4f3778f21197d11ff994d8bf4822049020207d0").HexToByteArray();

            public static byte[] s_RSAKeyTransfer3Cer =
                 ("308201c830820131a00302010202104497d870785a23aa4432ed0106ef72a6300d06092a864886f70d0101050500301a3118"
                + "30160603550403130f5253414b65795472616e7366657233301e170d3136303332353231323335355a170d31373033323630"
                + "33323335355a301a311830160603550403130f5253414b65795472616e736665723330819f300d06092a864886f70d010101"
                + "050003818d0030818902818100bbc6fe8702a4e92eadb9b0f41577c0fffc731411c6f87c27c9ef7c2e2113d4269574f44f2e"
                + "90382bd193eb2f57564cf00092172d91a003e7252a544958b30aab6402e6fba7e442e973d1902e383f6bc4a4d8a00e60b3f3"
                + "3a032bdf6bedb56acb0d08669b71dd7b35f5d39d9914f5e111e1cd1559eb741a3075d673c39e7850a50203010001a30f300d"
                + "300b0603551d0f040403020520300d06092a864886f70d01010505000381810058abccbf69346360351d55817a61a6091b0b"
                + "022607caeb44edb6f05a91f169903608d7391b245ac0dcbe052e16a91ac1f8d9533f19f6793f15cb6681b2cbaa0d8e83d77b"
                + "5207e7c70d843deda8754af8ef1029e0b68c35d88c30d7da2f85d1a20dd4099facf373341b50a8a213f735421062e1477459"
                + "6e27a32e23b3f3fcfec3").HexToByteArray();

            // password = "1111"
            public static byte[] s_RSAKeyTransfer3Pfx =
                 ("308205d20201033082058e06092a864886f70d010701a082057f0482057b308205773082034806092a864886f70d010701a0"
                + "82033904820335308203313082032d060b2a864886f70d010c0a0102a08202a6308202a2301c060a2a864886f70d010c0103"
                + "300e0408a9197ad512c316b5020207d004820280b1c213fa87f3906cde3502249830a01d1d636d0058bd8d6172222544c35a"
                + "9676f390a5ef1d52f13fae2f04fe2ca1bcb9914296f97fdf729a52e0c3472c9f7ae72bd746f0a66b0c9363fae0328ad063fa"
                + "45d35cc2679c85e970c7420ad036012ce553ef47ed8fe594917739aab1123be435a0ca88ac4b85cf3d341d4aeb2c6816d8fc"
                + "a2e9611224b42f0ca00bde4f25db460200f25fe99ed4fd0236e4d00c48085aec4734f0bce7e6c8fea08b11a2a7214f4a18c0"
                + "fa4b732c8dae5c5857f2edec27fa94eb17ac05d1d05b321b01c1368231ff89c46c6378abf67cb751156370bbcc35591e0028"
                + "d4ace5158048d9d25b00e028b7766f1c74ade9603a211aad241fc3b7599a2b15f86846dfdc106f49cf56491b3f6ff451d641"
                + "400f38fabcdb74a4423828b041901fa5d8c528ebf1cc6169b08eb14b2d457acb6970a11ccaa8fbc3b37b6454803b07b1916e"
                + "2ad3533f2b72721625c11f39a457033744fde3745c3d107a3f1e14118e04db41ca8970a383e8706bcf8ba5439a4cb360b250"
                + "4fcae3dbfb54af0154f9b813ad552f2bdbc2a9eb61d38ae5e6917990cbeb1c5292845637c5fed477dabbed4198a2978640ba"
                + "7db22c85322115fa9027ad418a61e2e31263da3776398faaaab818aae6423c873bd393f558fa2fc05115b4983d35ecfeae13"
                + "601519a53c7a77b5688aeddc6f210a65303eeb0dbd7e3a5ec94d7552cf4cbe7acebf5e4e10abaccd2e990f1cf217b98ad9b5"
                + "06820f7769a7c5e61d95462918681c2b111faf29f13e3615c4c5e75426dbcd903c483590434e8ab1965dc620e7d8bebea36f"
                + "53f1bc0807933b0ef9d8cc1b36b96aff8288e9a8d1bba24af562dfeb497b9a58083b71d76dacd6f2ce67cb2593c6f06472ef"
                + "e508012c34f40d87e0be3174301306092a864886f70d0109153106040401000000305d06092b060104018237110131501e4e"
                + "004d006900630072006f0073006f0066007400200053006f0066007400770061007200650020004b00650079002000530074"
                + "006f0072006100670065002000500072006f007600690064006500723082022706092a864886f70d010701a0820218048202"
                + "14308202103082020c060b2a864886f70d010c0a0103a08201e4308201e0060a2a864886f70d01091601a08201d0048201cc"
                + "308201c830820131a00302010202104497d870785a23aa4432ed0106ef72a6300d06092a864886f70d0101050500301a3118"
                + "30160603550403130f5253414b65795472616e7366657233301e170d3136303332353231323335355a170d31373033323630"
                + "33323335355a301a311830160603550403130f5253414b65795472616e736665723330819f300d06092a864886f70d010101"
                + "050003818d0030818902818100bbc6fe8702a4e92eadb9b0f41577c0fffc731411c6f87c27c9ef7c2e2113d4269574f44f2e"
                + "90382bd193eb2f57564cf00092172d91a003e7252a544958b30aab6402e6fba7e442e973d1902e383f6bc4a4d8a00e60b3f3"
                + "3a032bdf6bedb56acb0d08669b71dd7b35f5d39d9914f5e111e1cd1559eb741a3075d673c39e7850a50203010001a30f300d"
                + "300b0603551d0f040403020520300d06092a864886f70d01010505000381810058abccbf69346360351d55817a61a6091b0b"
                + "022607caeb44edb6f05a91f169903608d7391b245ac0dcbe052e16a91ac1f8d9533f19f6793f15cb6681b2cbaa0d8e83d77b"
                + "5207e7c70d843deda8754af8ef1029e0b68c35d88c30d7da2f85d1a20dd4099facf373341b50a8a213f735421062e1477459"
                + "6e27a32e23b3f3fcfec33115301306092a864886f70d0109153106040401000000303b301f300706052b0e03021a0414cd11"
                + "0833d653f2e18d2afb2de74689ff0446ec7d0414f2ca1c390db19317697044b9012ef6864e0f05cc020207d0").HexToByteArray();

            public static byte[] s_RSAKeyTransferCapi1Cer =
                 ("3082020c30820179a00302010202105d2ffff863babc9b4d3c80ab178a4cca300906052b0e03021d0500301e311c301a0603"
                + "55040313135253414b65795472616e736665724361706931301e170d3135303431353037303030305a170d32353034313530"
                + "37303030305a301e311c301a060355040313135253414b65795472616e73666572436170693130819f300d06092a864886f7"
                + "0d010101050003818d0030818902818100aa272700586c0cc41b05c65c7d846f5a2bc27b03e301c37d9bff6d75b6eb6671ba"
                + "9596c5c63ba2b1af5c318d9ca39e7400d10c238ac72630579211b86570d1a1d44ec86aa8f6c9d2b4e283ea3535923f398a31"
                + "2a23eaeacd8d34faaca965cd910b37da4093ef76c13b337c1afab7d1d07e317b41a336baa4111299f99424408d0203010001"
                + "a3533051304f0603551d0104483046801015432db116b35d07e4ba89edb2469d7aa120301e311c301a060355040313135253"
                + "414b65795472616e73666572436170693182105d2ffff863babc9b4d3c80ab178a4cca300906052b0e03021d050003818100"
                + "81e5535d8eceef265acbc82f6c5f8bc9d84319265f3ccf23369fa533c8dc1938952c5931662d9ecd8b1e7b81749e48468167"
                + "e2fce3d019fa70d54646975b6dc2a3ba72d5a5274c1866da6d7a5df47938e034a075d11957d653b5c78e5291e4401045576f"
                + "6d4eda81bef3c369af56121e49a083c8d1adb09f291822e99a429646").HexToByteArray();

            // Password = "1111"
            //
            // Built by:
            //
            //   makecert -r -len 1024 -n "CN=RSAKeyTransferCapi1" -b 04/15/2015 -e 04/15/2025 RSAKeyTransferCapi1.cer -sv RSAKeyTransferCapi1.pvk -sky exchange
            //   pvk2pfx.exe -pvk RSAKeyTransferCapi1.pvk -spc RSAKeyTransferCapi1.cer -pfx RSAKeyTransferCapi1.pfx -po 1111
            //  
            public static byte[] s_RSAKeyTransferCapi1Pfx =
                 ("30820626020103308205e206092a864886f70d010701a08205d3048205cf308205cb3082035806092a864886f70d010701a0"
                + "82034904820345308203413082033d060b2a864886f70d010c0a0102a08202b6308202b2301c060a2a864886f70d010c0103"
                + "300e0408dbd82a9abd7c1a2b020207d004820290768873985e74c2ece506531d348d8b43f2ae8524a2bcc737eeb778fac1ee"
                + "b21f82deb7cf1ba54bc9a865be8294de23e6648ffb881ae2f0132265c6dacd60ae55df1497abc3eb9181f47cb126261ea66f"
                + "d22107bbcdb8825251c60c5179ef873cb7e047782a4a255e3e9d2e0dd33f04cde92f9d268e8e4daf8ba74e54d8b279a0e811"
                + "9a3d0152608c51331bbdd23ff65da492f85809e1d7f37af9ae00dca796030a19e517e7fe2572d4502d4738fd5394ee369216"
                + "fb64cf84beab33860855e23204156dcf774fac18588f1c1ca1a576f276e9bfbf249449842f193020940a35f163378a2ce7da"
                + "37352d5b0c7c3ac5eb5f21ed1921a0076523b2e66a101655bb78d4ecc22472ac0151b7e8051633747d50377258ab19dcb22e"
                + "e09820876607d3291b55bba73d713d6689486b310507316b4f227383e4869628ad31f0b431145d45f4f38f325772c866a20e"
                + "0b442088cbf663e92e8ee82dd495fba8d40345474a384bb3b80b49ca1d66eef5321235135dcc0a5425e4bf3b8ce5c2469e2a"
                + "c0f8d53aab276361d9a2ff5c974c6e6b66126158676331fe7f74643fd1e215b22d7799846651350ed0f1f21a67ac6b3bfd62"
                + "7defb235ef8732d772d1c4bea2ae80c165f0182f547ea7a3f3366288f74c030689988a9838c27b10a48737a620d8220f68b4"
                + "ea8d8eb26298d5359d54a59c6be6716cefc12c929e17bb71c57c560659a7757ba8ac08ae90794474e50f0e87a22e2b7c3ebd"
                + "061390928bf48c6c6200c225f7025eab20f5f6fee5dc41682b2d4a607c8c81964b7d52651e5a62a41f4e8ea3982c294a4aee"
                + "8a67dc36a8b34b29509a4868c259dc205d1e8a3b6259a76a147f002f3bfbc8378e8edd230a34f9cd5f13ce6651b10394709d"
                + "5092bb6a70d8c2816f1c0e44cd45dfa7c2d94aa32112d79cb44a3174301306092a864886f70d010915310604040100000030"
                + "5d06092b060104018237110131501e4e004d006900630072006f0073006f006600740020005300740072006f006e00670020"
                + "00430072007900700074006f0067007200610070006800690063002000500072006f007600690064006500723082026b0609"
                + "2a864886f70d010701a082025c048202583082025430820250060b2a864886f70d010c0a0103a082022830820224060a2a86"
                + "4886f70d01091601a0820214048202103082020c30820179a00302010202105d2ffff863babc9b4d3c80ab178a4cca300906"
                + "052b0e03021d0500301e311c301a060355040313135253414b65795472616e736665724361706931301e170d313530343135"
                + "3037303030305a170d3235303431353037303030305a301e311c301a060355040313135253414b65795472616e7366657243"
                + "6170693130819f300d06092a864886f70d010101050003818d0030818902818100aa272700586c0cc41b05c65c7d846f5a2b"
                + "c27b03e301c37d9bff6d75b6eb6671ba9596c5c63ba2b1af5c318d9ca39e7400d10c238ac72630579211b86570d1a1d44ec8"
                + "6aa8f6c9d2b4e283ea3535923f398a312a23eaeacd8d34faaca965cd910b37da4093ef76c13b337c1afab7d1d07e317b41a3"
                + "36baa4111299f99424408d0203010001a3533051304f0603551d0104483046801015432db116b35d07e4ba89edb2469d7aa1"
                + "20301e311c301a060355040313135253414b65795472616e73666572436170693182105d2ffff863babc9b4d3c80ab178a4c"
                + "ca300906052b0e03021d05000381810081e5535d8eceef265acbc82f6c5f8bc9d84319265f3ccf23369fa533c8dc1938952c"
                + "5931662d9ecd8b1e7b81749e48468167e2fce3d019fa70d54646975b6dc2a3ba72d5a5274c1866da6d7a5df47938e034a075"
                + "d11957d653b5c78e5291e4401045576f6d4eda81bef3c369af56121e49a083c8d1adb09f291822e99a429646311530130609"
                + "2a864886f70d0109153106040401000000303b301f300706052b0e03021a041463c18f4fec17cf06262e8acd744e18b8ab7b"
                + "8f280414134ec4a25653b142c3d3f9999830f2ac66ef513b020207d0").HexToByteArray();

            public static byte[] s_RSASha256KeyTransfer1Cer =
                 ("308201d43082013da003020102021072c6c7734916468c4d608253da017676300d06092a864886f70d01010b05003020311e"
                + "301c060355040313155253415368613235364b65795472616e7366657231301e170d3136303431383130353934365a170d31"
                + "37303431383136353934365a3020311e301c060355040313155253415368613235364b65795472616e736665723130819f30"
                + "0d06092a864886f70d010101050003818d0030818902818100cad046de3a7f6dc78fc5a4e01d1f7d90db596f586334d5708a"
                + "ecb8e52d6bb912c0b5ec9633a82b4abac4c2860c766f2fdf1c905c4a72a54adfd041adabe5f2afd1e2ad88615970e818dc3d"
                + "4d00bb6c4ce94c5eb4e3efedd80d14c3d295ea471ae430cbb20b071582f1396369fbe90c14aa5f85b8e3b14011d81fbd41ec"
                + "b1495d0203010001a30f300d300b0603551d0f040403020520300d06092a864886f70d01010b050003818100baed2a5ae2d1"
                + "1ee4209c0694c790e72e3e8ad310b2506b277d7c001b09f660d48dba846ac5bbef97653613adf53d7624fc9b2b337f25cb33"
                + "74227900cfefbe2fdac92b4f769cf2bf3befb485f282a85bfb09454b797ce5286de560c219fb0dd6fce0442adbfef4f767e9"
                + "ac81cf3e9701baf81efc73a0ed88576adff12413b827").HexToByteArray();

            // password = "1111"
            public static byte[] s_RSASha256KeyTransfer1Pfx =
                 ("308205de0201033082059a06092a864886f70d010701a082058b04820587308205833082034806092a864886f70d010701a0"
                + "82033904820335308203313082032d060b2a864886f70d010c0a0102a08202a6308202a2301c060a2a864886f70d010c0103"
                + "300e040829e4911057aa5fb6020207d00482028052e016e1e339ca6a648ab1e152813899bd2ec0de1e34804c33e109cf2136"
                + "d42edc0d5ff8a005939ec38d4284aa0cfda295e801b701855c3c129e9311dc80b3538ba76d3164d48d83a73949d695f42294"
                + "75469f262c807767bc5c12bb83b2c4857fa9f8c7c519143136ba93ab93e17ad4b0b63cf6449708e6128425b00eaeae6bc5b6"
                + "7ff092673c9aabbbb63e90424295f0ae828bcd00f5ad85fe8384711ca5fffd4cbfe57ddbc3e5bb1df19e6fd7640fbd8d4516"
                + "f8d2d5ec84baca72ac42b50e77be0055dfdbbbe9c6de42c06fc86de8fbfc6231db89b30065d534e76aa851833b6c9c651288"
                + "c12f87ba12ae429e9bec0b22297c666046355ebd5a54dc7f13a55e0ebd53c768f69eee57d6041263f5bdf1c4c5b2b55dfb9b"
                + "38171aaed0d21fd5a41e0ef760db42f373c9007e1df47fd79ba9b41528c9c02dffdd04472265763ae94f4e05b86976a2c459"
                + "093d8e6bb0d0c5da5994fe3edbdf843b67e8e4c4daf59351788bf8b96da116aecbb95d52bf727ff10ca41340112f0bcb41e0"
                + "b8373a6e55727c745b77cf1944b74fa447ed0a6d93b8e43fd6e4b4b3e0d49d03ee2ee12d15519406c49a4c1be70de5171c93"
                + "d056e9f47b8a96d50f01873be4c596590f1247a2f2822dea9339fa87dd49545b559e0225ab738ecc0b054155749670d412be"
                + "472d13dfb0a8c8f56b3c0be1aa0d9195ba937b0c2119c702a0be1f83e1b4a77375ed1654e3dcf6b8ce119db3ac7cd440369a"
                + "b0b964e0b526b865680015cc3046a20badeaca4543ce65042ff5eb691e93232754a7b34fd8b6833c2625fdfdc59d80b3dcb4"
                + "ce70d1833ecf6344bb7331e46b71bb1592b6d814370548ee2b2f4df207696be87d2e1e0c5dc0ca528e5a231802cbb7853968"
                + "beb6ceb1b3a2998ecd313174301306092a864886f70d0109153106040401000000305d06092b060104018237110131501e4e"
                + "004d006900630072006f0073006f0066007400200053006f0066007400770061007200650020004b00650079002000530074"
                + "006f0072006100670065002000500072006f007600690064006500723082023306092a864886f70d010701a0820224048202"
                + "203082021c30820218060b2a864886f70d010c0a0103a08201f0308201ec060a2a864886f70d01091601a08201dc048201d8"
                + "308201d43082013da003020102021072c6c7734916468c4d608253da017676300d06092a864886f70d01010b05003020311e"
                + "301c060355040313155253415368613235364b65795472616e7366657231301e170d3136303431383130353934365a170d31"
                + "37303431383136353934365a3020311e301c060355040313155253415368613235364b65795472616e736665723130819f30"
                + "0d06092a864886f70d010101050003818d0030818902818100cad046de3a7f6dc78fc5a4e01d1f7d90db596f586334d5708a"
                + "ecb8e52d6bb912c0b5ec9633a82b4abac4c2860c766f2fdf1c905c4a72a54adfd041adabe5f2afd1e2ad88615970e818dc3d"
                + "4d00bb6c4ce94c5eb4e3efedd80d14c3d295ea471ae430cbb20b071582f1396369fbe90c14aa5f85b8e3b14011d81fbd41ec"
                + "b1495d0203010001a30f300d300b0603551d0f040403020520300d06092a864886f70d01010b050003818100baed2a5ae2d1"
                + "1ee4209c0694c790e72e3e8ad310b2506b277d7c001b09f660d48dba846ac5bbef97653613adf53d7624fc9b2b337f25cb33"
                + "74227900cfefbe2fdac92b4f769cf2bf3befb485f282a85bfb09454b797ce5286de560c219fb0dd6fce0442adbfef4f767e9"
                + "ac81cf3e9701baf81efc73a0ed88576adff12413b8273115301306092a864886f70d0109153106040401000000303b301f30"
                + "0706052b0e03021a0414282ee1780ac2a08b2783b1f8f7c855fb1a53ce9e04143fad59471323dc979f3bf29b927e54eca677"
                + "7576020207d0").HexToByteArray();

            public static byte[] s_RSASha384KeyTransfer1Cer =
                 ("308201d43082013da00302010202103c724fb7a0159a9345caac9e3df5f136300d06092a864886f70d01010c05003020311e"
                + "301c060355040313155253415368613338344b65795472616e7366657231301e170d3136303431383131303530365a170d31"
                + "37303431383137303530365a3020311e301c060355040313155253415368613338344b65795472616e736665723130819f30"
                + "0d06092a864886f70d010101050003818d0030818902818100e6b46b0e6f4f6df724081e11f201b9fbb07f2b6db2b868f607"
                + "68e2b5b843f690ca5e8d48f439d8b181ace2fb27dfa07eff0324642d6c9129e2d95e136702f6c31fe3ccf3aa87ba9f1b6f7b"
                + "acd07156ff3dd2a7f4c70356fb94b0adbde6819383c19bbefb4a6d1d6491a770d5f9feb11bcb3e5ac99cb153984dee0910e4"
                + "b57f8f0203010001a30f300d300b0603551d0f040403020520300d06092a864886f70d01010c0500038181003842cc95a680"
                + "c8a31534a461d061a4706a0aba52b7a1c709c2f1e3b94acf6dc0930b74e63e3babf3c5b11c8f8a888722d9f23c7e0a8c9b09"
                + "90ebcdbce563b8d4209efc1b04750f46c8c6117ccb96b26b5f02b0b5f961ab01b0c3b4cdb2530cbc5dcf37786712a3476ce7"
                + "32c5c544c328db5ebc3a338b18fe32aedaffedd973ef").HexToByteArray();

            // password = "1111"
            public static byte[] s_RSASha384KeyTransfer1Pfx =
                 ("308205de0201033082059a06092a864886f70d010701a082058b04820587308205833082034806092a864886f70d010701a0"
                + "82033904820335308203313082032d060b2a864886f70d010c0a0102a08202a6308202a2301c060a2a864886f70d010c0103"
                + "300e040856d7d59810ce8b17020207d00482028082012797edb5f74429bb6b91dd1e24aa32a19b89d92fd486e826773a7a11"
                + "03a9b49d98c6b7e97d411d19b44cd79559964f31cb6f0443c70d687c390d31c656ee3887391ae1735c142d891ec8337c5dc4"
                + "d6b5a4f09400a4cc35dd8dbde831f7625b7afedf4990294988b0b32b2889c97cd85c2568ffef332be83232449dd4083a43d4"
                + "89e654520eb922239379b5e9f5dfc1e64972339dee27dfdd874e2ee2b85f941f3b313ab881571c3a5a9b292d8c82d79d74a0"
                + "2d78dd5cfce366b3a914b61b861b35948757d137e5d53589a0fa2f1b4d06ee6b4aa4b8d3f526b059637b236ceb2de128d7bd"
                + "f91c12612d09e1cb4bed1b5e336fb56424b68dcc6d6cd5d90f666047c8b181526a60622027d322db0172046c23e84a3c725e"
                + "45ce774df037cafb74b359c3ec6874dce98673d9f7581f54dcb6e3c40583de2de6aaf6739bba878362e9bfab331cab2eb22d"
                + "3b130dec4eedf55a7ed8d5960e9f037209f9c1ef584c6dd5de17245d0da62c54420dc862b6648418d2aa9797f86a2cd0ecf6"
                + "abcbeb16907d8f44021690682a4e1286cd3f9aea4866108b3c968cf4b80a39c60436079617346861662e01a5419d8cebe2c6"
                + "e186141e42baf7cfc596270dbab8db03da9bd501daa426e24aa2d8ccf4d4512a8dce3ae8954be69b5c3a70fac587ac91ad97"
                + "fb427c8118659b710b57183c4fd16ffd276834e2fe45d74e175f3f5077783cdd7668b4e87217512ceb7f3e64715ba22bbab7"
                + "0d1b3485820c16304758cf1dd0b806d801f1185bb14d12f2c147ec65b95088077dec23498ebe40a952727c559c7af5cf20f1"
                + "f491f4123db093dc1a67014c3db46c11c7d5833b15167c91138eba6b4badf869aefba5fbea523a5ad02bb676db6039e7aabd"
                + "44f0702d59cf3d1ad9bb3174301306092a864886f70d0109153106040401000000305d06092b060104018237110131501e4e"
                + "004d006900630072006f0073006f0066007400200053006f0066007400770061007200650020004b00650079002000530074"
                + "006f0072006100670065002000500072006f007600690064006500723082023306092a864886f70d010701a0820224048202"
                + "203082021c30820218060b2a864886f70d010c0a0103a08201f0308201ec060a2a864886f70d01091601a08201dc048201d8"
                + "308201d43082013da00302010202103c724fb7a0159a9345caac9e3df5f136300d06092a864886f70d01010c05003020311e"
                + "301c060355040313155253415368613338344b65795472616e7366657231301e170d3136303431383131303530365a170d31"
                + "37303431383137303530365a3020311e301c060355040313155253415368613338344b65795472616e736665723130819f30"
                + "0d06092a864886f70d010101050003818d0030818902818100e6b46b0e6f4f6df724081e11f201b9fbb07f2b6db2b868f607"
                + "68e2b5b843f690ca5e8d48f439d8b181ace2fb27dfa07eff0324642d6c9129e2d95e136702f6c31fe3ccf3aa87ba9f1b6f7b"
                + "acd07156ff3dd2a7f4c70356fb94b0adbde6819383c19bbefb4a6d1d6491a770d5f9feb11bcb3e5ac99cb153984dee0910e4"
                + "b57f8f0203010001a30f300d300b0603551d0f040403020520300d06092a864886f70d01010c0500038181003842cc95a680"
                + "c8a31534a461d061a4706a0aba52b7a1c709c2f1e3b94acf6dc0930b74e63e3babf3c5b11c8f8a888722d9f23c7e0a8c9b09"
                + "90ebcdbce563b8d4209efc1b04750f46c8c6117ccb96b26b5f02b0b5f961ab01b0c3b4cdb2530cbc5dcf37786712a3476ce7"
                + "32c5c544c328db5ebc3a338b18fe32aedaffedd973ef3115301306092a864886f70d0109153106040401000000303b301f30"
                + "0706052b0e03021a041429bd86de50f91b8f804b2097b1d9167ca56577f40414b8714b8172fa1baa384bed57e3ddb6d1851a"
                + "f5e9020207d0").HexToByteArray();

            public static byte[] s_RSASha512KeyTransfer1Cer =
                 ("308201d43082013da00302010202102f5d9d58a5f41b844650aa233e68f105300d06092a864886f70d01010d05003020311e"
                + "301c060355040313155253415368613531324b65795472616e7366657231301e170d3136303431383131303532355a170d31"
                + "37303431383137303532355a3020311e301c060355040313155253415368613531324b65795472616e736665723130819f30"
                + "0d06092a864886f70d010101050003818d0030818902818100b2eca20240da8486b1a933ade62ad8781ef30d4434ebbc9b3f"
                + "c9c550d0f9a75f4345b5520f3d0bafa63b8037785d1e8cbd3efe9a22513dc8b82bcd1d44bf26bd2c292205ca3e793ff1cb09"
                + "e0df4afefb542362bc148ea2b76053d06754b4a37a535afe63b048282f8fb6bd8cf5dc5b47b7502760587f84d9995acbf1f3"
                + "4a3ca10203010001a30f300d300b0603551d0f040403020520300d06092a864886f70d01010d050003818100493d857684d2"
                + "7468dd09926d20933254c7c79645f7b466e7b4a90a583cedba1c3b3dbf4ccf1c2506eb392dcf15f53f964f3c3b519132a38e"
                + "b966d3ea397fe25457b8a703fb43ddab1c52272d6a12476df1df1826c90fb679cebc4c04efc764fd8ce3277305c3bcdf1637"
                + "91784d778663194097180584e5e8ab69039908bf6f86").HexToByteArray();

            // password = "1111"
            public static byte[] s_RSASha512KeyTransfer1Pfx =
                 ("308205de0201033082059a06092a864886f70d010701a082058b04820587308205833082034806092a864886f70d010701a0"
                + "82033904820335308203313082032d060b2a864886f70d010c0a0102a08202a6308202a2301c060a2a864886f70d010c0103"
                + "300e04083a0e344b65dd4e27020207d00482028014464df9f07d2cb37a28607570130de5877e829e759040976866afc831db"
                + "4d2741734ae53ea5eb80c1080dae7b0a2acddabd3d47b1ed5f3051455429308f3b7b0b48c5a4dbc5d718534472c746ce62f1"
                + "bbb8c5d178c1d3e91efdbd4f56569517bcadf3c81dbe4c34746194e47bcf46b74cd1880d7bd12d9b819b462fbcf6f51f3972"
                + "2858c9b9af8975bfefd7f007928b39e11d50b612761d03e566b992f92e9c9873d138c937fc43fe971db4c8e57b51aeef4ed0"
                + "022ec76c3bb4bd9f2395b99585449303a6d68183edf6e5dda1885531bee10b7cf6509390f4ee6a37ed2931d658548bd6390f"
                + "a7094fdf017166309074c00581d2b7dcaaee657f9c48e08edf636004dc5e60486dd022c45058700fe682472b371380948792"
                + "74c2a20dd9e07e149e7ab52157db748160ad81f91019297baa58ce68656b0b2f7c9ac88b3da6920c2a5eab7bcc2629974f8a"
                + "6c8bf33629af05e4e34d5d24393448e9751b7708f5915b0fd97a5af4dd5a37d71b18b6526316cbc65b1c6af8a6779acbc470"
                + "2381f027bdb118cb84e9005b02a8bd2d02365d280cffb04831f877de7bd3d3287f11beed8978a5389e2b28317eb90569781f"
                + "94f66f672736a09b4a7caeaaefd1909f2d20255df51512dbd08ec6125455d932b626bdfd3c4f669148fa783671f90b59ceff"
                + "560c338f92cbe8bf7fbab4db3e9b943effac747eb34f06bd72aee961ed31742caa2a9934a5fe4685677ecbca6fb1b1c0b642"
                + "b4f71d55d0e2cb1dc10ce845514090cc117a875c4d10c0ce367e31091144eacd7e600792d61d036bde020e3bb9a004a7dd1a"
                + "cf03541b6fff3bcef4c30df05d98b75688320685261b2b34813407b20a7c92a04eeb46cb7e618a6ee32154728ba6735668f4"
                + "11abece4ba07426a394b3174301306092a864886f70d0109153106040401000000305d06092b060104018237110131501e4e"
                + "004d006900630072006f0073006f0066007400200053006f0066007400770061007200650020004b00650079002000530074"
                + "006f0072006100670065002000500072006f007600690064006500723082023306092a864886f70d010701a0820224048202"
                + "203082021c30820218060b2a864886f70d010c0a0103a08201f0308201ec060a2a864886f70d01091601a08201dc048201d8"
                + "308201d43082013da00302010202102f5d9d58a5f41b844650aa233e68f105300d06092a864886f70d01010d05003020311e"
                + "301c060355040313155253415368613531324b65795472616e7366657231301e170d3136303431383131303532355a170d31"
                + "37303431383137303532355a3020311e301c060355040313155253415368613531324b65795472616e736665723130819f30"
                + "0d06092a864886f70d010101050003818d0030818902818100b2eca20240da8486b1a933ade62ad8781ef30d4434ebbc9b3f"
                + "c9c550d0f9a75f4345b5520f3d0bafa63b8037785d1e8cbd3efe9a22513dc8b82bcd1d44bf26bd2c292205ca3e793ff1cb09"
                + "e0df4afefb542362bc148ea2b76053d06754b4a37a535afe63b048282f8fb6bd8cf5dc5b47b7502760587f84d9995acbf1f3"
                + "4a3ca10203010001a30f300d300b0603551d0f040403020520300d06092a864886f70d01010d050003818100493d857684d2"
                + "7468dd09926d20933254c7c79645f7b466e7b4a90a583cedba1c3b3dbf4ccf1c2506eb392dcf15f53f964f3c3b519132a38e"
                + "b966d3ea397fe25457b8a703fb43ddab1c52272d6a12476df1df1826c90fb679cebc4c04efc764fd8ce3277305c3bcdf1637"
                + "91784d778663194097180584e5e8ab69039908bf6f863115301306092a864886f70d0109153106040401000000303b301f30"
                + "0706052b0e03021a041401844058f6e177051a87eedcc55cc4fa8d567ff10414669cb82c9cc3ceb4d3ca9f65bd57ba829616"
                + "60d9020207d0").HexToByteArray();

            public static byte[] s_DHKeyAgree1Cer =
                 ("3082041930820305a00302010202100ae59b0cb8119f8942eda74163413a02300906052b0e03021d0500304f314d304b0603"
                + "5504031e44004d0061006e006100670065006400200050004b00430053002300370020005400650073007400200052006f00"
                + "6f007400200041007500740068006f0072006900740079301e170d3136303431333132313630315a170d3339313233313233"
                + "353935395a301f311d301b06035504031314446648656c6c654b657941677265656d656e7431308201b63082012b06072a86"
                + "48ce3e02013082011e02818100b2f221e2b4649401f817557771e4f2ca1c1309caab3fa4d85b03dc1ea13c8395665eb4d05a"
                + "212b33e1d727403fec46d30ef3c3fd58cd5b621d7d30912f2360676f16b206aa419dba39b95267b42f14f6500b1729de2d94"
                + "ef182ed0f3042fd3850a7398808c48f3501fca0e929cec7a9594e98bccb093c21ca9b7dbdfcdd733110281805e0bed02dd17"
                + "342f9f96d186d2cc9e6ff57f5345b44bfeeb0da936b37bca62e2e508d9635a216616abe777c3fa64021728e7aa42cfdae521"
                + "01c6a390c3eb618226d8060ceacdbc59fa43330ad41e34a604b1c740959b534f00bd6cf0f35b62d1f8de68d8f37389cd435d"
                + "764b4abec5fc39a1e936cdf52a8b73e0f4f37dda536902150093ced62909a4ac3aeca9982f68d1eed34bf055b30381840002"
                + "81804f7e72a0e0ed4aae8e498131b0f23425537b9a28b15810a3c1ff6f1439647f4e55dcf73e72a7573ce609a5fb5c5dc3dc"
                + "daa883b334780c232ea12b3af2f88226775db48f4b800c9ab1b54e7a26c4c0697bbd5e09355e3b4ac8005a89c65027e1d0d7"
                + "091b6aec8ede5dc72e9bb0d3597915d50da58221673ad8a74e76b2a79f25a38194308191300c0603551d130101ff04023000"
                + "3081800603551d010479307780109713ac709a6e2cc6aa54b098e5557cd8a151304f314d304b06035504031e44004d006100"
                + "6e006100670065006400200050004b00430053002300370020005400650073007400200052006f006f007400200041007500"
                + "740068006f00720069007400798210d581eafe596cd7a34d453011f4a4b6f0300906052b0e03021d05000382010100357fbe"
                + "079401e111bf80db152752766983c756eca044610f8baab67427dc9b5f37df736da806e91a562939cf876a0998c1232f31b9"
                + "9cf38f0e34d39c7e8a2cc04ed897bfdc91f7f292426063ec3ec5490e35c52a7f98ba86a4114976c45881373dacc95ad3e684"
                + "7e1e28bb58e4f7cfc7138a56ce75f01a8050194159e1878bd90f9f580f63c6dd41e2d15cd80dc0a8db61101df9009d891ec2"
                + "28f70f3a0a37358e7917fc94dfeb6e7cb176e8f5dbfa1ace2af6c0a4306e22eb3051e7705306152ce87328b24f7f153d565b"
                + "73aef677d25ae8657f81ca1cd5dd50404b70b9373eadcd2d276e263105c00607a86f0c10ab26d1aafd986313a36c70389a4d"
                + "1a8e88").HexToByteArray();
        }
    }
}


