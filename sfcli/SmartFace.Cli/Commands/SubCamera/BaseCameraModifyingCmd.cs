using McMaster.Extensions.CommandLineUtils;
using SmartFace.Cli.Core.ApiAbstraction.Models;

namespace SmartFace.Cli.Commands.SubCamera
{
    public abstract class BaseCameraModifyingCmd
    {   
        [Option("-e|--enabled", "Whether the stream is processed or not", CommandOptionType.SingleValue)]
        public (bool HasValue, bool Value) Enabled { get; }
        
        [Option("-i|--minFaceSize", "Minimum count of pixels between eyes", CommandOptionType.SingleValue)]
        public (bool HasValue, int Value) TrackMinFaceSize { get; }
        
        [Option("-x|--maxFaceSize", "Maximum count of pixels between eyes", CommandOptionType.SingleValue)]
        public (bool HasValue, int Value) TrackMaxFaceSize { get; }
        
        [Option("-r|--redetectionTime", "Time between face re-detections in milliseconds", CommandOptionType.SingleValue)]
        public (bool HasValue, int Value) RedetectionTime { get; }
        
        [Option("-p|--mpeg1PreviewPort", "Port to processed stream MPEG1 preview", CommandOptionType.SingleValue)]
        public (bool HasValue, int Value) MPEG1PreviewPort { get; }

        [Option("-tg|--templateGeneratorResource", "Template generator resource id for the camera", CommandOptionType.SingleValue)]
        public (bool HasValue, string Value) TemplateGeneratorResourceId { get; }

        [Option("-fd|--faceDetectorResource", "Face detector resource for the camera", CommandOptionType.SingleValue)]
        public (bool HasValue, string Value) FaceDetectorResourceId { get; }

        public abstract (bool HasValue, string Value) Name { get; }
        public abstract (bool HasValue, string Value) VideoSource { get; }

        protected void SetBaseParameters(CameraRequestData cameraRequestData)
        {
            if (VideoSource.HasValue)
            {
                cameraRequestData.Source = VideoSource.Value;
            }
            
            if (Enabled.HasValue)
            {
                cameraRequestData.Enabled = Enabled.Value;
            }

            if (TrackMinFaceSize.HasValue)
            {
                cameraRequestData.TrackMinFaceSize = TrackMinFaceSize.Value;
            }

            if (TrackMaxFaceSize.HasValue)
            {
                cameraRequestData.TrackMaxFaceSize = TrackMaxFaceSize.Value;
            }

            if (RedetectionTime.HasValue)
            {
                cameraRequestData.RedetectionTime = RedetectionTime.Value;
            }

            if (MPEG1PreviewPort.HasValue)
            {
                cameraRequestData.MPEG1PreviewPort = MPEG1PreviewPort.Value;
            }

            if (TemplateGeneratorResourceId.HasValue)
            {
                cameraRequestData.TemplateGeneratorResourceId = TemplateGeneratorResourceId.Value;
            }

            if (FaceDetectorResourceId.HasValue)
            {
                cameraRequestData.FaceDetectorResourceId = FaceDetectorResourceId.Value;
            }

            if (Name.HasValue)
            {
                cameraRequestData.Name = Name.Value;
            }
        }
    }
}