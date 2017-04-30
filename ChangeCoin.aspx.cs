using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private Bank bank;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        int moneyUser = Int32.Parse(tbMoney.Text);
        change_Money(moneyUser);
    }

    protected void AddBank_Click(object sender, EventArgs e)
    {
        bank = new Bank();
        int a = Int32.Parse(tbBankB1000.Text);
        int b = Int32.Parse(tbBankB500.Text);
        int c = Int32.Parse(tbBankB100.Text);
        int d = Int32.Parse(tbBankB50.Text);
        int e2 = Int32.Parse(tbCoin10.Text);
        int f = Int32.Parse(tbCoin5.Text);
        int g = Int32.Parse(tbCoin1.Text);

        bank.b1000 = a;
        bank.b500 = b;
        bank.b100 = c;
        bank.b50 = d;
        bank.c10 = e2;
        bank.c5 = f;
        bank.c1 = g;

        lbBankB1000.Text ="แบงค์ 1000 มีจำนวน : "+ bank.b1000.ToString();
        lbBankB500.Text = "แบงค์ 500 มีจำนวน : " + bank.b500.ToString();
        lbBankB100.Text = "แบงค์ 100 มีจำนวน : " + bank.b100.ToString();
        lbBankB50.Text = "แบงค์  50 มีจำนวน : " + bank.b50.ToString();
        lbCoin10.Text = "เหรียญ  10 มีจำนวน : " + bank.c10.ToString();
        lbCoin5.Text = "เหรียญ   5 มีจำนวน : " + bank.c5.ToString();
        lbCoin1.Text = "เหรียญ   1 มีจำนวน : " + bank.c1.ToString();

    }

    public void change_Money(int money)
    {
        //Debug.WriteLine("Bank details - {0}", bank);
        Debug.WriteLine("ถอนเงิน   : " + money + " บาท");

        int change_b1000 = 0;
        int change_b500 = 0;
        int change_b100 = 0;
        int change_b50 = 0;
        int change_c10 = 0;
        int change_c5 = 0;
        int change_c1 = 0;

        int bankvalue = 0;
        bankvalue += bank.b1000 * 1000;
        bankvalue += bank.b500 * 500;
        bankvalue += bank.b100 * 100;
        bankvalue += bank.b50 * 50;
        bankvalue += bank.c10 * 10;
        bankvalue += bank.c5 * 5;
        bankvalue += bank.c1 * 1;

        Debug.WriteLine("bankvalue : " + bankvalue);

        if (money <= bankvalue)
        {
            while (money > 0)
            {
                if (money >= 1000)
                {
                    if (checkvalue(bank.b1000))
                    {
                        bank.b1000--;
                        change_b1000++;
                        money -= 1000;
                        //Debug.WriteLine("1000 pass");
                    }
                    else
                    {
                        lbError.Text = "Bank B1000 ไม่สามารถทอนได้ เนื่องจาก ไม่มีเศษ";
                        //Debug.WriteLine("Bank B1000 ไม่สามารถทอนได้ เนื่องจาก ไม่มีเศษ");
                        break;
                    }
                }
                else if (money >= 500)
                {
                    if (checkvalue(bank.b500))
                    {
                        bank.b500--;
                        change_b500++;
                        money -= 500;
                    }
                    else
                    {
                        lbError.Text = "Bank B500 ไม่สามารถทอนได้ เนื่องจาก ไม่มีเศษ";
                        //Debug.WriteLine("Bank B500 ไม่สามารถทอนได้ เนื่องจาก ไม่มีเศษ");
                        break;
                    }
                }
                else if (money >= 100)
                {

                    if (checkvalue(bank.b100))
                    {
                        bank.b100--;
                        change_b100++;
                        money -= 100;
                    }
                    else
                    {
                        lbError.Text = "Bank B100 ไม่สามารถทอนได้ เนื่องจาก ไม่มีเศษ";
                        //Debug.WriteLine("Bank B100 ไม่สามารถทอนได้ เนื่องจาก ไม่มีเศษ");
                        break;
                    }
                }
                else if (money >= 50)
                {

                    if (checkvalue(bank.b50))
                    {
                        bank.b50--;
                        change_b50++;
                        money -= 50;
                    }
                    else
                    {
                        lbError.Text = "Bank B50 ไม่สามารถทอนได้ เนื่องจาก ไม่มีเศษ";
                        //Debug.WriteLine("Bank B50 ไม่สามารถทอนได้ เนื่องจาก ไม่มีเศษ");
                        break;
                    }
                }
                else if (money >= 10)
                {
                    if (checkvalue(bank.c10))
                    {
                        bank.c10--;
                        change_c10++;
                        money -= 10;
                    }
                    else
                    {
                        lbError.Text = "Bank c10 ไม่สามารถทอนได้ เนื่องจาก ไม่มีเศษ";
                        //Debug.WriteLine("Bank c10 ไม่สามารถทอนได้ เนื่องจาก ไม่มีเศษ");
                        break;
                    }
                }
                else if (money >= 5)
                {
                    if (checkvalue(bank.c5))
                    {
                        bank.c5--;
                        change_c5++;
                        money -= 5;
                    }
                    else
                    {
                        lbError.Text = "Bank c5 ไม่สามารถทอนได้ เนื่องจาก ไม่มีเศษ";
                        //Debug.WriteLine("Bank c5 ไม่สามารถทอนได้ เนื่องจาก ไม่มีเศษ");
                        break;
                    }
                }
                else if (money >= 1)
                {
                    if (checkvalue(bank.c1))
                    {
                        bank.c1--;
                        change_c1++;
                        money -= 1;
                    }
                    else
                    {
                        lbError.Text = "Bank c1 ไม่สามารถทอนได้ เนื่องจาก ไม่มีเศษ";
                        //Debug.WriteLine("Bank c1 ไม่สามารถทอนได้ เนื่องจาก ไม่มีเศษ");
                        break;
                    }
                }
            }
        }
        else
        {
            lbError.Text = "ไม่สามารถทอนได้ เนื่องจาก เงินไม่เพียงพอ";
        }



        lbB1000.Text = "ถอนแบงค์  1000   : " + change_b1000 + " คงเหลือ : " + bank.b1000;
        lbB500.Text = "ถอนแบงค์  500    : " + change_b500 + " คงเหลือ: " + bank.b500;
        lbB100.Text = "ถอนแบงค์  100    : " + change_b100 + " คงเหลือ: " + bank.b100;
        lbB50.Text = "ถอนแบงค์  50    : " + change_b50 + " คงเหลือ : " + bank.b50;
        lbC10.Text = "ถอนเหรียญ 10     : " + change_c10 + " คงเหลือ : " + bank.c10;
        lbC5.Text = "ถอนเหรียญ 5      : " + change_c5 + " คงเหลือ : " + bank.c5;
        lbC1.Text = "ถอนเหรียญ 1      : " + change_c1 + " คงเหลือ : " + bank.c1;
        /*
        Debug.WriteLine("ถอนแบงค์  1000   : " + change_b1000 + " คงเหลือ : " + bank.b1000);
        Debug.WriteLine("ถอนแบงค์  500    : " + change_b500 + " คงเหลือ : " + bank.b500);
        Debug.WriteLine("ถอนแบงค์  100    : " + change_b100 + " คงเหลือ : " + bank.b100);
        Debug.WriteLine("ถอนแบงค์  50     : " + change_b50 + " คงเหลือ : " + bank.b50);
        Debug.WriteLine("ถอนเหรียญ 10     : " + change_c10 + " คงเหลือ : " + bank.c10);
        Debug.WriteLine("ถอนเหรียญ 5      : " + change_c5 + " คงเหลือ : " + bank.c5);
        Debug.WriteLine("ถอนเหรียญ 1      : " + change_c1 + " คงเหลือ : " + bank.c1);
        */
    }

    public Boolean checkvalue(int value)
    {
        if (value > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}

public class Bank
{
    private int b1000s;
    private int b500s;
    private int b100s;
    private int b50s;
    private int c10s;
    private int c5s;
    private int c1s;


    /*  แบงค์ 1000:   10
        แบงค์ 500: 5
        แบงค์ 100: 10
        แบงค์ 50: 10
        เหรียญ 10: 1000
        เหรียญ 5: 500
        เหรียญ 1: 1000
    */

    public int b1000
    {
        get
        {
            return b1000s;
        }

        set
        {
            b1000s = value;
        }
    }
    public int b500
    {
        get
        {
            return b500s;
        }

        set
        {
            b500s = value;
        }
    }
    public int b100
    {
        get
        {
            return b100s;
        }

        set
        {
            b100s = value;
        }
    }
    public int b50
    {
        get
        {
            return b50s;
        }

        set
        {
            b50s = value;
        }
    }
    public int c10
    {
        get
        {
            return c10s;
        }

        set
        {
            c10s = value;
        }
    }
    public int c5
    {
        get
        {
            return c5s;
        }

        set
        {
            c5s = value;
        }
    }
    public int c1
    {
        get
        {
            return c1s;
        }

        set
        {
            c1s = value;
        }
    }

}