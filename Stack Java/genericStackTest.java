public class genericStackTest<Type> 
{
    int size, top;
    Type stackArr[];
    @SuppressWarnings("unchecked")
    genericStackTest(int size)
	{
        this.size=size;
        top=-1;
        stackArr=(Type[]) new Object[size];
    }
    boolean isEmpty(){
        return (top==-1);
    }
    boolean isFull(){
        return(top==size);
    }
    void push(Type Value){
        if(!isFull())
		{
            stackArr[++top]=Value;
        }
        else
		{
            System.out.println("Array is Full");
        }
    }
    Type pop()
	{
        if(!isEmpty())
		{
            return stackArr[top--];
        }
        else
		{
            System.out.println("Array is empty");
            return null;
        }
    }
    Type peek()
	{
        return stackArr[top];
    }
}
class StackApp
{
    String ConvertToPostfix(String c)
	{
        int position=0;
        genericStackTest<Character> stackArr = new genericStackTest<Character>(c.length());
        String output = new String();
        while(position!=c.length())
		{
            if(c.charAt(position)=='(')
			{
                stackArr.push(c.charAt(position++));
            }
            else if(Character.isLetterOrDigit(c.charAt(position)))
			{
                output+=c.charAt(position++);
            }
            else if(c.charAt(position)==')')
			{
                while(!stackArr.isEmpty() && stackArr.peek()!='(')
				{
                    output+=stackArr.pop();
                }
                stackArr.pop();
                position++;
            }
            else{
                while(stackArr.isEmpty() || operatorValue(c.charAt(position))>operatorValue(stackArr.peek())||stackArr.peek()=='('||stackArr.peek()==')'){
                    stackArr.push(c.charAt(position++));
                }
            }
        }
        while(!stackArr.isEmpty())
		{
            output+=stackArr.pop();
        }
        return output;
    }
    int operatorValue(char value)
	{
        switch (value) 
		{
            case '^':
                return 3;
            case '*':
            case '/':
                return 2;
            case '+':
            case '-':
                return 1;
            default:
                return -1;
        }
    }
    int EvaluatePostfix(String c)
	{
        genericStackTest<Character> stackArr = new genericStackTest<Character>(c.length());
        int position=0;
        int var1, var2, calculation;
        while(position!=c.length()){
            if(c.charAt(position) >= '0' && c.charAt(position) <= '9'){
                stackArr.push(c.charAt(position++));
            }
            else{
                var2 = stackArr.pop()-'0';
                var1 = stackArr.pop()-'0';
                switch (c.charAt(position)){
                    case '+':
                    calculation=var1+var2;
                    break;
                    case '-':
                    calculation=var1-var2;
                    break;
                    case '/':
                    calculation=var1/var2;
                    break;
                    case '*':
                    calculation=var1*var2;
                    break;
                    case '^':
                    calculation=var1^var2;
                    break;
                    default:
                    calculation=0;
                    break;
                }
                stackArr.push((char)(calculation+'0'));
                position++;
            }
        }
        return (int)(stackArr.pop()-'0');
    }
    public static void main(String[] args) {
        String Expression="(6+2)*(5-3)";
        StackApp ob1 = new StackApp();
        System.out.println("Answer = "+ob1.EvaluatePostfix(ob1.ConvertToPostfix(Expression)));
    }
}