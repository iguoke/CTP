using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace FZtool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string openaddr = "";
        public string openaddr1 = "";
        public string saveaddr = "F:/ctpstruct.cs";
        bool iffz = false;
        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "请选择需要封装文件地址...\r\n";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "文档(*.h;*.cpp)|*.h;*.cpp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName != "")
                {
                    openaddr = openFileDialog1.FileName;
                    openaddr1 = openaddr.Replace("ThostFtdcUserApiStruct.h", "ThostFtdcUserApiDataType.h");
                    //this.textBox1.Text = openFileDialog1.FileName;
                    FileStream fs = new FileStream(@openaddr, FileMode.Open, FileAccess.Read);
                    //读取
                    StreamReader reader = new StreamReader(fs, Encoding.GetEncoding("GB2312"));
                    string str = "";
                    string strline = "";
                    int row = reader.ReadToEnd().Split('\n').Length;
                    fs.Position = 0;
                    this.textBox1.Text += "正在封装....\r\n";
                    FileStream fs1 = new FileStream(@openaddr1, FileMode.Open, FileAccess.Read);
                    StreamReader reader1 = new StreamReader(fs1, Encoding.GetEncoding("GB2312"));
                    int row1 = reader1.ReadToEnd().Split('\n').Length;
                    fs1.Position = 0;
                    string strline1 = "";
                    string type = "";
                    int ty = 0;
                    string str1 = "";
                    string str4 = "";
                    string[] typestr=new  string[10];
                    for (int i = 0; i < row1 - 1; i++)
                    {
                        strline1 = reader1.ReadLine();
                        if (strline1.Contains("typedef"))
                        {
                            str1 = strline1.Substring(strline1.Substring(0, strline1.LastIndexOf(" ")).LastIndexOf(" ") + 1, strline1.LastIndexOf(" ") - strline1.Substring(0, strline1.LastIndexOf(" ")).LastIndexOf(" ") - 1);
                            if (!type.Contains(str1))
                            {
                                type += str1 + " \r\n";
                                typestr[ty++] = str1;
                            }  
                            

                        }
                    }
                    

                    strline1 = "";
                    str1 = "";
                    fs1.Position = 0;
                    #region 结构体封装

                    for (int i = 0; i < row - 2; i++)
                    {
                        // Console.WriteLine(i.ToString());
                        strline = reader.ReadLine();
                        if (strline.Contains("///信息分发"))
                        {
                            iffz = true;
                            str += "///本文件的转换工具由刘建平提供\r\n" + "using System;\r\nusing System.Collections.Generic;\r\n"
                                + "using System.Linq;\r\nusing System.Text;\r\nusing System.Runtime.InteropServices;\r\n"
                                + "namespace CTPAPI\r\n{\r\n";
                        }
                        if (iffz)
                        {
                            if (strline.Contains("struct C"))
                            {
                                strline = strline.Replace("struct", "public struct");
                                str += "[StructLayout(LayoutKind.Sequential)]" + "\r\n"
                                       + strline + "\r\n";

                            }
                            else if (strline.Contains("}"))
                            {
                                strline = strline.Replace(";", "");
                                str += strline + "\r\n";
                            }
                            else if (strline.Contains("///") && !strline.Contains("////"))
                            {
                                str += "/// <summary>\r\n" + strline + "\r\n" + "/// <summary>\r\n";
                            }
                            else if (strline.Contains("TThost"))
                            {

                                str1 = strline.Substring(strline.LastIndexOf("TThost"), strline.LastIndexOf("\t") - 1);
                                fs1.Position = 0;
                                
                                #region 循环查找类型
                                for (int j = 0; j < row1 - 1; j++)
                                {
                                    //Console.WriteLine(j.ToString());
                                    strline1 = reader1.ReadLine();
                                    //string strline1_1 = "";  
                                    if (strline1 != null)
                                    {
                                        //Console.WriteLine("sr1:   "+str1);
                                        //Console.WriteLine(strline1);
                                        if (strline1.Contains(str1))
                                        {
                                            
                                            if (strline1.Contains("short"))
                                            {
                                                if (!str4.Contains("short"))
                                                {
                                                    str4 += "short\r\n";
                                                }
                                                strline = strline.Replace(str1, "public short");
                                          
                                                str += strline + "\r\n";
                                                break;
                                            }
                                            else if (strline1.Contains("int"))
                                            {
                                                if (!str4.Contains("int"))
                                                {
                                                    str4 += "int\r\n";
                                                }
                                                strline = strline.Replace(str1, "public int");
                                                str += strline + "\r\n";
                                                break;
                                            }
                                            else if (strline1.Contains("double"))
                                            {
                                                if (!str4.Contains("double"))
                                                {
                                                    str4 += "double\r\n";
                                                }
                                                strline = strline.Replace(str1, "public double");
                                                str += strline + "\r\n";
                                                break;
                                            }
                                            else if (strline1.Contains("char"))
                                            {
                                                if (!str4.Contains("char"))
                                                {
                                                    str4 += "char\r\n";
                                                }
                                                if (strline1.Contains("["))
                                                {
                                                    // Console.WriteLine(strline1.Substring(strline1.LastIndexOf("[") + 1, strline1.LastIndexOf("]") - strline1.LastIndexOf("[") - 1));
                                                    //Console.WriteLine(strline1.Substring(strline1.LastIndexOf("char") + 5, strline1.LastIndexOf("[") - strline1.LastIndexOf("char") - 5));
                                                    //strline1.Replace("", "public string");
                                                    strline = strline.Replace(str1, "[MarshalAs(UnmanagedType.ByValTStr, SizeConst = "
                                                             + strline1.Substring(strline1.LastIndexOf("[") + 1, strline1.LastIndexOf("]") - strline1.LastIndexOf("[") - 1).ToString()
                                                             + ")]" + "\r\n" + "public string");
                                                    str += strline + "\r\n";
                                                    break;
                                                }
                                                else
                                                {
                                                    //strline = strline.Replace(str1, "public char");
                                                    str +="public "+ strline + "\r\n";
                                                    break;
                                                }
                                               
                                            }
                                        }
                                    }

                                }
                                #endregion 循环查找类型
                                // Console.WriteLine(str1);
                            }
                            else
                            {
                                str += strline + "\r\n";
                            }

                        }
                        //iffz = false;
                    }
                    #endregion 结构体封装
                    #region 枚举的封装
                    fs1.Position = 0;
                    row1 = reader1.ReadToEnd().Split('\n').Length;
                    fs1.Position = 0;
                    strline1 = "";
                    str1 = "";
                    string str2 = "";
                    string str3 = "";
                    bool ifin = false;
                    string[] parm = new string[1000];
                    int l = 0;
                    int ll=1;
                    //Console.WriteLine(row1.ToString());
                    for (int j = 0; j < row1 - 2; j++)
                    {
                        strline1 = reader1.ReadLine();
                        //Console.WriteLine(j.ToString ());
                        //Console.WriteLine(strline1+"\r\n");
                        if (strline1 != null && strline1.Contains("typedef") && strline1.Contains("char") && !strline1.Contains("["))
                        {

                            str1 = strline1.Substring(strline1.LastIndexOf("char") + 5, strline1.LastIndexOf(";") - strline1.LastIndexOf("char") - 5);

                            //str1 = str1.Replace("Thost", "");
                            parm[l++] = str1;
                        }
                    }
                    fs1.Position = 0;
                    strline1 = "";
                    l = 0;
                    for (int k = 0; k < row1 - 2; k++)
                    {
                        strline1 = reader1.ReadLine();
                        if (ifin && strline1 != null)
                        {
                            if (strline1.Contains("///") && !strline1.Contains("////"))
                            {
                                str += "/// <summary>\r\n" + strline1 + "\r\n" + "/// <summary>\r\n";
                            }
                            if (strline1.Contains("#define") && strline1.Contains("'"))
                            {
                                str2 = strline1.Substring(strline1.LastIndexOf("#define") + 8, strline1.LastIndexOf(" ") - strline1.LastIndexOf("#define") - 8);
                                str3 = strline1.Substring(strline1.Substring(0, strline1.LastIndexOf("'")).LastIndexOf("'"), strline1.LastIndexOf("'") - strline1.Substring(0, strline1.LastIndexOf("'")).LastIndexOf("'") + 1);
                                if (str3.Length > 3)
                                {
                                    str3="'"+ll.ToString() +"'";
                                    ll++;
                                }
                                str += str2 + "=(byte)" + str3 + ",\r\n";
                                //Console.WriteLine(str3);
                            }
                            if (strline1.Contains(parm[l]) && !strline1.Contains("是一个"))
                            {
                                str = str.Substring(0, str.LastIndexOf(","));

                                str += "\r\n}\r\n";
                                l++;
                                ll = 1;
                                ifin = false;
                            }
                        }
                        else
                        {
                            if (strline1 != null && parm[l] != null)
                            {
                                if (strline1.Contains(parm[l].Replace("Thost", "")) && strline1.Contains("是一个"))
                                {

                                    //Console.WriteLine(strline1);
                                    str += "/// <summary>\r\n" + strline1 + "\r\n" + "/// <summary>\r\n";
                                    str += "public enum " + parm[l] + " : byte \r\n" + "{ \r\n";
                                    //l++;
                                    ifin = true;
                                }
                            }
                        }
                       
                    }
                    this.textBox1.Text += "对比需要封装的类型:\r\n" + type;
                    this.textBox1.Text += "已经封装的类型:\r\n" + str4;
                    #endregion 枚举的封装
                    iffz = false;
                    str += "}";
                    reader.Close();
                    fs.Close();
                    reader1.Close();
                    fs1.Close();
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.RestoreDirectory = true;
                    this.textBox1.Text += "结构体封装完成，请选择保存地址....\r\n";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //获得文件路径
                        saveaddr = saveFileDialog1.FileName.ToString();
                        //设置文件类型
                        //saveFileDialog1.Filter = " cs files(*.cs)|*.cs|All files(*.*)|*.*";
                    }
                    StreamWriter writer;
                    writer = new StreamWriter(@saveaddr);
                    writer.Write(str);
                    writer.Close();
                    this.textBox1.Text += "保存完成->" + saveaddr + "\r\n";
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             this.textBox1.Text += "请选择需要封装文件地址...\r\n";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "文档(*.h;*.cpp)|*.h;*.cpp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName != "")
                {
                    openaddr = openFileDialog1.FileName;
                    //openaddr1 = openaddr.Replace("ThostFtdcUserApiStruct.h", "ThostFtdcUserApiDataType.h");
                    //this.textBox1.Text = openFileDialog1.FileName;
                    FileStream fs = new FileStream(@openaddr, FileMode.Open, FileAccess.Read);
                    //读取
                    StreamReader reader = new StreamReader(fs, Encoding.GetEncoding("GB2312"));
                    string str = "", str1 = "", str0="",str2 = "", str3 = "", str4 = "", str5 = "", str6 = "", str7 = "", str11 = "";
                    string strline = "";
                    string classname="",fclassname="";
                    
                    int row = reader.ReadToEnd().Split('\n').Length;
                    fs.Position = 0;
                    this.textBox1.Text += "正在封装....\r\n";
                    if(openaddr.Contains("ThostFtdcMdApi.h"))
                    {
                        classname="CTPMDAPI";
                        fclassname="CThostFtdcMdSpi";
                        str0="CCTPMDAPI";
                    }
                    if(openaddr.Contains("ThostFtdcTraderApi.h"))
                    {
                        str0 = "CCTPTDAPI";
                        classname="CTPTDAPI";
                        fclassname="CThostFtdcTraderSpi";
                    }
                    bool ifin = false;
                    //str4 += ;
                    //str7 += ;
                    for (int i = 0; i < row - 1; i++)
                    { 
                        strline=reader .ReadLine();
                        if (strline.Contains("class") && strline.Contains(fclassname))
                        {
                            ifin = true;
                            strline = "";
                            str += "///本文档有刘建平提供转换工具\r\n#include \"stdafx.h\"\r\n#include \r\n#ifdef "+classname+"_EXPORTS\r\n#define "+classname+"_API __declspec(dllexport)\r\n#else\r\n#define \r\n"+classname+"_API __declspec(dllimport)\r\n#endif\r\nclass  "+"C"+classname +":public "+fclassname +"\r\n";                           
                        }
                        if (ifin)
                        {
                            
                            if (strline.Contains("{};"))
                            {

                                strline=strline.Replace("{};", ";");
                                str += strline + "\r\n";
                                strline = strline.Replace("virtual void ", "");
                                str5 = strline.Replace(";","");
                                str5 = str5.Replace("\t","");
                                strline  =  strline.Replace("(",")(");
                                strline = strline.Replace("\t", "typedef int (WINAPI *CB");
                                str1 +=strline+ "\r\n";
                                strline = strline.Substring(0, strline.Substring(0, strline.LastIndexOf(')')).LastIndexOf(')'));
                                strline = strline.Substring(strline.LastIndexOf('*')+1);
                                str3=strline.Replace("CB", "cb");
                                str2 += strline +" "+str3+ "=0;\r\n";
                                str6 = str5.Substring(str5.LastIndexOf('('));
                                str11 = str5.Substring(0,str5.LastIndexOf('('));
                                string str8 = "", str9 = "", str10 = "";
                                bool ifc = false;
                                for(int j=0;j<str6.Length;j++)
                                {
                                    
                                    str8 = str6.Substring(j, 1);
                                    if (str8 == " ")
                                    {
                                        //str9 = "";
                                        ifc=true;
                                    }
                                    else if (str8 == "," || str8 == ")")
                                    {
                                        str10 += str9;
                                        ifc = false;
                                    }
                                    if (str8 == " " && ifc ==true)
                                    {
                                        str9 = "";
                                        ifc = true;
                                    }
                                    if (ifc)
                                    {
                                        str9 += str8;
                                    }
                                   // textBox1.Text += str9;
                                }
                                str10 = str10.Replace("*","");
                                if (str10.Length>1)
                                {
                                    str10 = str10.Substring(1);
                                    str10 = str10.Replace(" ",",");
                                }
                                
                                str4 += "void "+str0+"::" + str5 + "\r\n{\r\n" + "   if(" + str3 + "!=NULL)\r\n        " + str3+"("+str10 + ");\r\n}\r\n";
                                str7 += classname + "_API void WINAPI Reg" + str11 + "(CB" + str11 + " cb)\r\n{\r\n    " + str3 + "=cb;\r\n}\r\n";
                            }
                            else if (strline.Contains("};"))
                            {
                                str += strline.Replace("};", "\r\n    " + "C"+classname + "(void);\r\n};");
                            }
                            else if (strline.Contains("class MD_API_EXPORT CThostFtdcMdApi") || strline.Contains("class TRADER_API_EXPORT CThostFtdcTraderApi"))
                            {
                                str2 += "// 请求编号\r\nint iRequestID = 0;\r\n// UserApi对象\r\n"+fclassname.Replace("Spi","Api")+"* pUserApi;\r\n";
                                str4 += "C" + classname + "::" + "C" + classname + "()\r\n{\r\n return;\r\n}\r\n";
                                str += str1 + str2+str4+str7;
                                break;
                            }
                            else
                            {
                                str += strline + "\r\n";
                            }
                        }
                        
                    }
                    reader.Close();
                    fs.Close();
     
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.RestoreDirectory = true;
                    this.textBox1.Text += "结构体封装完成，请选择保存地址....\r\n";
                    saveaddr = "F:/"+classname+".cpp";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //获得文件路径
                        saveaddr = saveFileDialog1.FileName.ToString();
                        //设置文件类型
                        //saveFileDialog1.Filter = " cs files(*.cs)|*.cs|All files(*.*)|*.*";
                    }
                    StreamWriter writer;
                    writer = new StreamWriter(@saveaddr);
                    writer.Write(str);
                    writer.Close();
                    this.textBox1.Text += "保存完成->" + saveaddr + "\r\n";
                }
            }
        }
    }
}
