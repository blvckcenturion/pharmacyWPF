   M S B A M L   `   `   `  ����C  ?pharmacy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:pharmacypharmacy  5   	       pharmacy.SearchMed   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:pharmacy     5   	     � Title$  	SearchMed��5   	   $	��450��6   $	��500��6(   .��5	      � .+�5
   
   �� -   5         ��Name$
 txt1��5
      $��Center=�6"   $��0,10,0,0q�6?   $
��Wrap=�6Q   $	��Top=�6e   $��66��6}   $	��348��6�   $��40(�6�    �� TextAlignment$ Center=�6�   $��Segoe UI)�6�   $��Lista de Productos��6�   $��Normal"�6�   ���	#FF54D4796�   �� 5   
   -   5         ��Name$ 	txtSearch��5      $��Center=�6%   $��	0,101,0,0q�6B    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��302��6�   $��24��6�   ���	#FF54D479 �� TextAlignment$ Center=�6�   6�   	� 5   
   -   5         	�Name$ nameCheckBox��5      $��Busqueda por nombre��6,    	� 	GroupName$ searchBy��6J   $
��Left=�6_   $��
99,154,0,0q�6z   $	��Top=�6�   	� 5   
   -   5        $ priceCheckBox��5      $��Busqueda por precio��6-   $ searchBy��6K   $
��Left=�6`   $��272,154,0,0q�6{   $	��Top=�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
resultGrid��5      $��50,198,50,36q�6'   �� 5   
   -   5        $ 	txt1_Copy��5      $��Center=�6'   $��0,58,0,0q�6D   $
��Wrap=�6V   $	��Top=�6j   $��38��6�   $	��224��6�   $��20(�6�   $ Center=�6�   $��Segoe UI)�6�   $��Lista de Productos��6�   $��Normal"�6�   ���	#FFEC2E2E$y�Hidden=�6  5      5      