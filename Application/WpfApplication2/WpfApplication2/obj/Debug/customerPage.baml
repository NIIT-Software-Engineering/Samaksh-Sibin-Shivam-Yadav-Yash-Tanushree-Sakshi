   M S B A M L   `   `   `  ����J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2  5      "    WpfApplication2.customerPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WpfApplication2     5      -   5          N� Title$  customerPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��75 �6   �� 5      $��* �6   .+�5   
   �� $��Center=�6   .+�5      �� -   5        $��customerAddButton��5      $	��Add��6.   $��
10,0,20,10q�6<   6P   �� 5      -   5        $��customerEditButton��5      $
��Edit��6/   $��
10,0,20,10q�6>   6R   5      � 5   
   $��1��6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $��* �6    .+�5      �� $��Customer��6   $��5q�6(   $��Arial)�63   $��16(�6F   �� 5      -   5        $��customerSearchTextBox��5      $��Search��63   $��Right=�6A   $��Center=�6]   $��18��6x   $	��100��6�   $��0,0,40,0q�6�   6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ customerDataGrid��5      $��1��61   $��
0,10,40,20q�6>      AutoGenerateColumns .  ��6n   �� *LoadDataBinding+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Store Name��5    )      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 5!   )      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5   )   �� 
 �� Path$
 
store_name�5"   )     5#      $ Owner��5$   )   $ 1* 5%   )    . 	 5#   )   �� $
 store_owner�5&   )     5'      $ Mobile��5(   )   $ 1* 5)   )    . 	 5'   )   �� $
 store_mobile�5*   )     5+      $ Address��5,   )   $ 1* 5-   )    . 	 5+   )   �� $
 store_address�5.   )     5/      $ Email��50   )   $ 1* 51   )    . 	 5/   )   �� $
 store_email�52   )   54      55      56      57      