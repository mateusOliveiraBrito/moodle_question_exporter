using System.Collections.Generic;
using System.Xml.Serialization;

namespace moodle_question_exporter.Model {

    [XmlRoot(ElementName = "quiz")]
    public class Quiz {

        [XmlElement(ElementName = "question")]
        public List<Question> Question { get; set; }
    }
}