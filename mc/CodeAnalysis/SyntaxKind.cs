namespace Minsk.CodeAnalysis
{
    enum SyntaxKind
    {
        NumberToken,
        WhitespaceToken,
        PlusToken,
        MinusToken,
        SlashToken,
        StarToken,
        OpenParenthesisToken,
        CloseParenthesisToken,
        BadToken,
        EndOfFileToken,
        BinaryExpression,
        NumberExpression,
        ParenthesizedExpression
    }
}