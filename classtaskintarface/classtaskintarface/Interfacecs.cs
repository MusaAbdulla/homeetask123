namespace classtaskintarface
{
    internal interface ITextEditor
    {

        void Open();
        void Write(string text);
        void Save();
        void SaveAndClose(string filename);

    }
}
