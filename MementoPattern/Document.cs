using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Document
    {
        public string Content { get; set; }
        public string FontName { get; set; }
        public int FontSize { get; set; }

        public DocumentState CreateState()
        {
            return new DocumentState(Content, FontName, FontSize);
        }
        public void RestoreState(DocumentState state)
        {
            Content = state.Content;
            FontName = state.FontName;
            FontSize = state.FontSize;
        }


        public override string ToString()
        {
            return $"Content = {Content}; Font name = {FontName}; Font size = {FontSize}";
        }
    }
}
