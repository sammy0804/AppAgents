# Gestión de Rutas de Transporte

## Descripción del Proyecto

Este proyecto implementa un sistema de gestión de rutas de transporte compartido, diseñado para facilitar a los empleados la suscripción a rutas de transporte específicas y la gestión de sus suscripciones. El proyecto se centra en proporcionar una solución robusta y escalable, aprovechando las últimas tecnologías y prácticas de desarrollo.

## Características

- Gestión de empleados, vehículos y rutas.
- Suscripción a rutas de transporte.
- Visualización y administración de rutas y vehículos.

## Arquitectura del Sistema

La arquitectura del sistema está diseñada para ser escalable, segura y eficiente, utilizando una combinación de servicios en la nube y tecnologías de desarrollo modernas. Los componentes clave incluyen:

- **Azure App Service**: Para alojar las aplicaciones web y móviles.
- **Azure Active Directory**: Para gestionar la autenticación y autorización.
- **Azure SQL Database/Cosmos DB**: Para el almacenamiento y gestión de datos.
- **Azure Functions**: Para ejecutar tareas backend sin servidor.
- **Azure DevOps**: Para integración y despliegue continuos.

## Modelo Entidad-Relación (ERD)

El ERD del sistema define las entidades principales y sus relaciones:

- **Empleado (Employee)**: Representa a los usuarios del sistema.
- **Ruta (Route)**: Define las rutas de transporte disponibles.
- **Vehículo (Vehicle)**: Detalla los vehículos utilizados para las rutas.
- **Suscripción (Subscription)**: Gestiona las suscripciones de los empleados a las rutas.

  ![Diagrama sin título-Página-2 drawio](https://github.com/sammy0804/AppAgents/assets/51298297/eaff0602-2def-4343-9306-de087522f72a)


Cada entidad tiene atributos específicos y relaciones definidas que son cruciales para el funcionamiento del sistema.

## Tecnologías Utilizadas

El proyecto utiliza diversas tecnologías para lograr un sistema eficiente y moderno:

- **.NET 6**: Como framework principal para el desarrollo del backend.
- **React y React Native**: Para el desarrollo de la interfaz de usuario en la web y aplicaciones móviles.
- **Azure Cloud Services**: Para alojar y manejar los servicios del proyecto.
- **Git y Azure DevOps**: Para el control de versiones y la automatización del proceso de CI/CD.
