   M S B A M L   `   `   `  ���� J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2  #    WpfApplication2.wareHousePage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:WpfApplication2     -     N� Title$  wareHousePage��.���  � ColumnDefinitions �� $��75 ��� $��* �.+��� $��Center=�.+��� -   $��addProductButton��$	��Add��$��
10,0,20,10q��� -   $��refillProductButton��$��Refill��$��
10,0,20,10q��� -   $��updateProductButton��$��Bottom=�$��Update��$��
10,0,20,50q�� $��1�� � RowDefinitions �� $
��Auto ��� $��* �.+��� $��	WareHouse��$��5q�$��Arial)�$��16(��� -   $��wareHouseSearch��$��Search��$��Right=�$��Center=�$��18��$	��100��$��0,0,40,0q�&   System.Windows.Controls.DataGrid  -     Name$ wareHouseDataGrid��$��1��$��
0,10,40,20q�   AutoGenerateColumns .  ���� *LoadDataBinding+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Product Name��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 1*    
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 �� 
 �� Path$
 product_name�  $ Quantity(Box)��$ 1*  . 	 �� $
 product_quantity�  $ 	Price/Box��$ 1*  . 	 �� $
 product_pricepbox�  $ Manufacturer��$ 1*  . 	 �� $
 product_manufacturer�  $ Quantity/Box��$ 1*  . 	 �� $
 product_qtypbox�