using static laptrinhweb2_thuchanh.Models.DTO.PublishersDTO;
using System.Security.Policy;
using laptrinhweb2_thuchanh.Models.DTO;
using laptrinhweb2_thuchanh.Models.DTO;
using static laptrinhweb2_thuchanh.Models.DTO.PublishersDTO;
using laptrinhweb2_thuchanh.Models.Domain;

namespace laptrinhweb2_thuchanh.Repositories
{
    public interface IPublisherRepository
    {
        List<PublisherDTO> GetAllPublishers();
        PublisherNoIdDTO GetPublisherById(int id);
        AddPublishers AddPublisher(AddPublishers addPublisherRequestDTO);
        PublisherNoIdDTO UpdatePublisherById(int id, PublisherNoIdDTO publisherNoIdDTO);
        Publishers ? DeletePublisherById(int id);
    }
}