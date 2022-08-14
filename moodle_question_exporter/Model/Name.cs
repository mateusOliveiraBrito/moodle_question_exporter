using System.Xml.Serialization;

namespace moodle_question_exporter.Model {

    [XmlRoot(ElementName = "name")]
    public class Name {

        [XmlElement(ElementName = "text")]
        public string Text { get; set; }
    }
}