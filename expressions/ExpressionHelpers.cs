using System;
using System.Linq.Expressions;
using System.Reflection;
namespace Abituria
{
    public static class ExpressionHelpers///Pomocnik dla wyrażeń
    {
        public static T GetPropertyValue<T>(this Expression<Func<T>> lambda)///Kompiluje wyrażenie i bierze wartość zwracaną przez funkcje
        {
            return lambda.Compile().Invoke();
        }
        public static void SetPropertyValue<T>(this Expression<Func<T>> lambda, T value)///Ustawia właściwości z wyrrażenia
        {
            MemberExpression expression = (lambda as LambdaExpression).Body as MemberExpression;///Konwertuje lambda()=>jakaś.Właściwość na jakaś.Właściwość
            var propertyInfo = (PropertyInfo)expression.Member;///Weź informacje o właściwości
            var target = Expression.Lambda(expression.Expression).Compile().DynamicInvoke();
            propertyInfo.SetValue(target, value);/// Ustaw wartość właściwości
        }
    }
}