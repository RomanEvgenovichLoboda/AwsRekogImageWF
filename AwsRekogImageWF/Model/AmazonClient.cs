using Amazon.Rekognition;
using Amazon.S3;
using Amazon.S3.Transfer;

namespace AwsRekogImageWF.Model
{
    public static class AmazonClient
    {
        public const string acessKey = "AKIA344VMXIHI53J3UPT";
        public const string secretKey = "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";
        public static Amazon.RegionEndpoint regionEndpoint = Amazon.RegionEndpoint.EUCentral1;
        public const string bucketName = "reml2bucket";
        public static IAmazonS3 client = new AmazonS3Client(acessKey, secretKey, regionEndpoint);
        public static AmazonRekognitionClient rekognitionClient = new AmazonRekognitionClient(acessKey, secretKey, regionEndpoint);
        //public static TransferUtility transferUtil = new TransferUtility(acessKey,secretKey, regionEndpoint);

    }
}
