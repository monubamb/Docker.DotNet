using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [DataContract]
    public class NodeDescription // (swarm.NodeDescription)
    {
        [DataMember(Name = "Hostname", EmitDefaultValue = false)]
        public string Hostname { get; set; }

        [DataMember(Name = "Platform", EmitDefaultValue = false)]
        public Platform Platform { get; set; }

        [DataMember(Name = "Resources", EmitDefaultValue = false)]
        public Resources Resources { get; set; }

        [DataMember(Name = "Engine", EmitDefaultValue = false)]
        public EngineDescription Engine { get; set; }
    }
}
