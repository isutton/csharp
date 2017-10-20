// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Projection that may be projected along with other supported volume
    /// types
    /// </summary>
    public partial class Corev1VolumeProjection
    {
        /// <summary>
        /// Initializes a new instance of the Corev1VolumeProjection class.
        /// </summary>
        public Corev1VolumeProjection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Corev1VolumeProjection class.
        /// </summary>
        /// <param name="configMap">information about the configMap data to
        /// project</param>
        /// <param name="downwardAPI">information about the downwardAPI data to
        /// project</param>
        /// <param name="secret">information about the secret data to
        /// project</param>
        public Corev1VolumeProjection(Corev1ConfigMapProjection configMap = default(Corev1ConfigMapProjection), Corev1DownwardAPIProjection downwardAPI = default(Corev1DownwardAPIProjection), Corev1SecretProjection secret = default(Corev1SecretProjection))
        {
            ConfigMap = configMap;
            DownwardAPI = downwardAPI;
            Secret = secret;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets information about the configMap data to project
        /// </summary>
        [JsonProperty(PropertyName = "configMap")]
        public Corev1ConfigMapProjection ConfigMap { get; set; }

        /// <summary>
        /// Gets or sets information about the downwardAPI data to project
        /// </summary>
        [JsonProperty(PropertyName = "downwardAPI")]
        public Corev1DownwardAPIProjection DownwardAPI { get; set; }

        /// <summary>
        /// Gets or sets information about the secret data to project
        /// </summary>
        [JsonProperty(PropertyName = "secret")]
        public Corev1SecretProjection Secret { get; set; }

    }
}