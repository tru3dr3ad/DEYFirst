   M S B A M L   `   `   `  ����J  FBibliotecaVista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BibliotecaVistaBibliotecaVista  5   	   #    BibliotecaVista.CrearContrato   5      H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;Controls,http://metro.mahapps.com/winfx/xaml/controls  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:BibliotecaVista     5   	     � Title$  CrearContrato��5	   	   $	��450��6   $	��800��6,   .��5
      � .+�5   
   �� -   5         ��Name$ 	txtNroCon��5      $
��Left=�6%   $��23��6@   $��	59,51,0,0q�6L    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   -   5        $ txtFechaCrea��5      $
��Left=�6(   $��23��6C   $��
59,115,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   6�   �� 5   
   -   5        $ txtFechaTer��5      $
��Left=�6'   $��23��6B   $��
59,186,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5   
   -   5        $ 
txtHoraIni��5      $
��Left=�6&   $��23��6A   $��
59,244,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   -   5        $ 
txtHoraTer��5      $
��Left=�6&   $��23��6A   $��
59,300,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   -   5        $ txtDireccion��5      $
��Left=�6(   $��23��6C   $��
59,360,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   �� 5   
   -   5        $ txtIdEvento��5      $
��Left=�6'   $��23��6B   $��
273,51,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5   
   -   5        $ 
txtNombreE��5      $
��Left=�6&   $��23��6A   $��273,115,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5   
   -	   5        $ txtValor��5      $
��Left=�6$   $��23��6?   $��273,186,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5   
   -
   5        $ txtPersonal��5      $
��Left=�6'   $��23��6B   $��273,244,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   �� 5   
   -   5         ��Name$ chkSi��5      $��CheckBox��6"   $
��Left=�65   $��
488,51,0,0q�6P   $	��Top=�6d   �� 5   
   -   5        $ chkNo��5      $��CheckBox��6"   $
��Left=�65   $��
488,71,0,0q�6P   $	��Top=�6d   �� 5   
   $��Nro. Contrato��6   $
��Left=�6(   $��	59,31,0,0q�6C   $	��Top=�6V   �� 5   
   $��Fecha Creacion��6   $
��Left=�6)   $��	59,89,0,0q�6D   $	��Top=�6W   �� 5   
   $��Fecha Termino��6   $
��Left=�6(   $��
59,155,0,0q�6C   $	��Top=�6W   �� 5   
   $��Hora Inicio��6   $
��Left=�6&   $��
59,214,0,0q�6A   $	��Top=�6U   �� 5   
   $��Hora Termino��6   $
��Left=�6'   $��
59,272,0,0q�6B   $	��Top=�6V   �� 5   
   $��	Direccion��6   $
��Left=�6$   $��
59,328,0,0q�6?   $	��Top=�6S   �� 5   
   $��	Id Evento��6   $
��Left=�6$   $��
273,31,0,0q�6?   $	��Top=�6S   �� 5   
   $��Nombre Evento��6   $
��Left=�6(   $��
273,86,0,0q�6C   $	��Top=�6W   �� 5   
   $��
Valor Base��6   $
��Left=�6%   $��273,160,0,0q�6@   $	��Top=�6U   �� 5    
   $��Personal Base��6   $
��Left=�6(   $��273,218,0,0q�6C   $	��Top=�6X   �� 5!   
   $��Vigente��6   $
��Left=�6"   $��
488,31,0,0q�6=   $	��Top=�6Q   �� 5"   
   -   5        $ txtAsistente��5"      $
��Left=�6(   $��23��6C   $��273,300,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5#   
   $��Personal Asistente��6   $
��Left=�6-   $��273,280,0,0q�6H   $	��Top=�6]   �� 5$   
   -   5         ��Name$ btnCrear��5$      $��Crear Contrato��6#   $
��Left=�6<   $��567,244,0,0q�6W   $	��Top=�6l   $	��175��6�   $��72��6�   �� 5%   
   -   5        $ btnCancelar��5%      $��Cancelar��6&   $
��Left=�69   $��610,342,0,0q�6T   $	��Top=�6i   $��97��6�    J� RenderTransformOrigin$ 0.173,0.556&�6�   $��44��6�   6�   �� 5&   
   -   5        $ btnCalcularValor��5&      $��Calcular Valor��6+   $
��Left=�6D   $��
625,31,0,0q�6_   $	��Top=�6s   $	��150��6�   $��46��6�   6�   5(      5)      