   M S B A M L   `   `   `  ���� J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2  $    WpfApplication2.billDetailPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:WpfApplication2       N� Title$  billDetailPage��.���� $
��Auto=�.���  � RowDefinitions �� $
��Auto ��� $��* �.+��� $��Bill Details��$��1��$��Calibri)�$��22(�$��40,20,10,10q�$
��Bold"��� $��1��$	��Top=��� $��1��$	��Top=�.+��  � ColumnDefinitions �� $
��1.5* ��� $��2* ��� $
��1.5* ��� $��2* � �� $
��Auto ��� $
��Auto �.+��� $��	Bill ID :��$��0��$
��Bold"�$��Right=�$��5,5,5,5q�$��16(��� -   $��billIDLabel��$�� ��$��0��$��1��$
��Bold"�$
��Left=�$��5,5,5,5q�$��16(��� $��Store Name :��$��1��$��Right=�$��5,5,5,5q�$��16(��� -   $��storeNameTextBox�� �� TextAlignment$ Center=�$
��Yash��$��20(�$��1��$��1��{�.  $��30��$	��200��$��2��$
��Left=�$��5,5,5,5q��� $��Status :��$��0��$��2��$��Right=�$��5,5,5,5q�$��16(��� -   $��statusLabel��$�� ��$��0��$��3��$
��Left=�$��5q�$��16    (��� $��Date-Time :��$��1��$��2��$��Right=�$��5q�$��16(��� -   $��dateTimeLabel��$�� ��$��1��$��3��$
��Left=�$��5q�$��16    (��� $��	5,10,0,14q�$��------ Products ------- ��$��16(�$��Medium"�$��Center=��� $��Center=�$��Center=�$
��Auto��.+�&   System.Windows.Controls.DataGrid  -     Name$ productGrid��   AutoGenerateColumns .  $	��200��$	��600������ *LoadDataBinding+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Product��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 	   
IsReadOnly	 . 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 ��  �� Path$ product_name�  $ Quantity(Box)��$ 1* 	 . 
 �� $ product_qty�  $ Amt/Box��$ 1* 	 . 
 �� $ pricepproduct�  $ Total Amount��$ 1* 	 . 
 �� $ amount��� $��Right=�$��	0,20,40,0q�.+��  �� $
��Auto ��� $
��Auto ��� $
��Auto � �� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��Amount :��$��14(��� -   $��totalAmountLabel��$��1��$�� ��$��14(�$��Right=��� $��2��$��/- Rs��$��14(�$	��150���� $��Tax(%) :��$��1��$��14(��� -   $��
taxTextBox��{�.  $��1��$��1��$��20��$��Right=�$��60��$��5,0,0,0q�$ Right=��� $��2��$��1��$��%��$��14(�$	��150���� $��Total Bill :��$��2��$��14(��� -   $��taxAmountLabel��$��1��$��2��$�� ��$��Right=�$��14(��� $��2��$��2��$��/- Rs (with Tax)��$��14(�$	��150����  �� Orientation$ 
Horizontal=�$��Center=�.+��� -	   $��
doneButton��$��Center=�$��Center=�$
��Done��$��18(�$��80��$��20q�