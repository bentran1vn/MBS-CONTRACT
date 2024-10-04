using System.ComponentModel;
using MBS_CONTRACT.SHARE.Abstractions.Messages;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;

namespace MBS_CONTRACT.SHARE.Services.MentorSkills;

public class Command
{
    public record CreateMentorSkillsCommand : ICommand
    {
        public Guid SkillId { get; set; }
        
        [SwaggerSchema(ReadOnly = true)]
        [DefaultValue("e824c924-e441-4367-a03b-8dd13223f76f")]    
        public Guid MentorId { get; set; }
        
        public IFormFileCollection ProductImages { get; set; }
    }
}