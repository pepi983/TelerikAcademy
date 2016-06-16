namespace StringBuilder.Extensions
{
    using System.Text;
    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder builder, int index, int lenght)
        {
            string forAppend = builder.ToString().Substring(index, lenght);
            builder.Clear();
            builder.Append(forAppend);

            return builder;
        }
    }
}
