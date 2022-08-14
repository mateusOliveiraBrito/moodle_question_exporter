using System.Xml.Serialization;

namespace moodle_question_exporter.Model {

    [XmlRoot(ElementName = "questiontext")]
    public class Questiontext {

        [XmlElement(ElementName = "text")]
        public string Text { get; set; }

        [XmlAttribute(AttributeName = "format")]
        public string Format { get; set; }
    }
}