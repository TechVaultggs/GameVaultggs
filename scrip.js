// Referencias a los elementos del DOM
let menuToggle, navOverlay, closeMenu;

// Variables para el selector de moneda
let isUSD = false;
const exchangeRate = 3.3; // 1 USD = 3.3 PEN aproximadamente

// FUNCIONALIDAD DE PANTALLA DE CARGA
window.addEventListener('load', function() {
  const loadingScreen = document.getElementById('loading-screen');

  // Simular tiempo de carga mínimo
  setTimeout(() => {
    loadingScreen.classList.add('fade-out');

    // Remover completamente la pantalla de carga después de la transición
    setTimeout(() => {
      loadingScreen.style.display = 'none';
    }, 500);
  }, 500);
});

function toggleCurrency() {
  isUSD = !isUSD;
  updateCurrencyDisplay();
  updateAllPrices();
}

function updateCurrencyDisplay() {
  const currencySymbol = document.querySelector('.currency-symbol');
  const currencyText = document.querySelector('.currency-text');

  if (isUSD) {
    currencySymbol.textContent = '$';
    currencyText.textContent = 'USD';
  } else {
    currencySymbol.textContent = 'S/';
    currencyText.textContent = 'SOLES';
  }
}

function updateAllPrices() {
  const priceElements = document.querySelectorAll('.purchase-btn');

  priceElements.forEach(button => {
    const priceSpan = button.querySelector('.price');
    const originalPrice = parseFloat(button.dataset.priceSoles);

    if (isUSD) {
      const usdPrice = (originalPrice / exchangeRate).toFixed(2);
      priceSpan.textContent = `$ ${usdPrice}`;
    } else {
      priceSpan.textContent = `S/. ${originalPrice.toFixed(2)}`;
    }
  });
}

// Variables para controlar el scroll
let lastScrollTop = 0;
let isMenuOpen = false;
let scrollTimeout;

// Función para abrir el menú
function openMenu() {
  if (navOverlay) {
    navOverlay.classList.add("show");
    navOverlay.classList.add("show-on-scroll");
    navOverlay.classList.remove("hide-on-scroll");
    isMenuOpen = true;
    lastScrollTop = window.pageYOffset || document.documentElement.scrollTop;
  }
}

// Función para cerrar el menú
function closeMenuFunction() {
  if (navOverlay) {
    navOverlay.classList.remove("show");
    navOverlay.classList.remove("show-on-scroll");
    navOverlay.classList.remove("hide-on-scroll");
    isMenuOpen = false;
  }
}

// Función para manejar el scroll del menú
function handleMenuScroll() {
  if (!isMenuOpen) return;

  const currentScrollTop = window.pageYOffset || document.documentElement.scrollTop;

  // Limpiar timeout anterior
  clearTimeout(scrollTimeout);

  // Determinar dirección del scroll
  if (currentScrollTop > lastScrollTop + 5) {
    // Scrolleando hacia abajo - ocultar menú
    navOverlay.classList.add("hide-on-scroll");
    navOverlay.classList.remove("show-on-scroll");
  } else if (currentScrollTop < lastScrollTop - 5) {
    // Scrolleando hacia arriba - mostrar menú
    navOverlay.classList.remove("hide-on-scroll");
    navOverlay.classList.add("show-on-scroll");
  }

  // Actualizar posición de scroll después de un breve delay
  scrollTimeout = setTimeout(() => {
    lastScrollTop = currentScrollTop <= 0 ? 0 : currentScrollTop;
  }, 50);
}

// Función para detectar la página actual y establecer navegación activa
function setActiveNavBasedOnCurrentPage() {
  // Obtener todos los enlaces de navegación (desktop y móvil)
  const desktopLinks = document.querySelectorAll('.navbar .nav-links a');
  const mobileLinks = document.querySelectorAll('.nav-overlay .nav-links a');

  // Remover clase active de todos los enlaces
  [...desktopLinks, ...mobileLinks].forEach(link => {
    link.classList.remove('active');
  });

  // Obtener la página actual
  const currentPage = window.location.pathname.split('/').pop().toLowerCase();
  const currentPath = window.location.pathname.toLowerCase();

  // Si no hay página específica, usar el archivo actual o index
  const pageName = currentPage || 'index.html';

  // Lista de todas las páginas de guías (incluyendo almacenar.html)
  const guidePages = [
    'guias.html',
    'offline.html',
    'cuentas.html',
    'almacenar.html',
    'problemas-frecuentes.html',
    'politica-reembolsos.html',
    'responsabilidad-cliente.html',
    'enchanting.html'
  ];

  // Lista de páginas de juegos
  const gamePages = [
    'juegos.html',
    'juegosdolares.html'
  ];

  // Determinar qué sección debe estar activa
  let activeSection = 'INICIO'; // Valor por defecto cambiado

  // Lógica para determinar la sección activa - orden importante
  if (pageName === 'index.html' ||
      pageName === '' ||
      currentPath === '/' ||
      currentPath === '/index.html' ||
      currentPath.endsWith('/')) {
    activeSection = 'INICIO';
  } else if (guidePages.includes(pageName) ||
             pageName.includes('guia') ||
             pageName.includes('guide') ||
             pageName.includes('tutorial') ||
             pageName.includes('offline') ||
             pageName.includes('cuenta') ||
             pageName.includes('problema') ||
             pageName.includes('politica') ||
             pageName.includes('responsabilidad') ||
             pageName.includes('enchanting') ||
             pageName.includes('almacenar') ||
             currentPath.includes('guias')) {
    activeSection = 'GUIAS';
  } else if (gamePages.includes(pageName) ||
            pageName.includes('juego') ||
            pageName.includes('game') ||
            currentPath.includes('juegos')) {
    activeSection = 'JUEGOS';
  }

  // Aplicar clase active a los enlaces correspondientes
  [...desktopLinks, ...mobileLinks].forEach(link => {
    if (link.textContent.trim() === activeSection) {
      link.classList.add('active');
    }
  });
}

// Función para manejar navegación activa manual
function setActiveNavItem(clickedLink) {
  // Obtener todos los enlaces de navegación (desktop y móvil)
  const desktopLinks = document.querySelectorAll('.navbar .nav-links a');
  const mobileLinks = document.querySelectorAll('.nav-overlay .nav-links a');

  // Remover clase active de todos los enlaces
  [...desktopLinks, ...mobileLinks].forEach(link => {
    link.classList.remove('active');
  });

  // Obtener el texto del enlace clickeado
  const linkText = clickedLink.textContent.trim();

  // Agregar clase active a los enlaces correspondientes en ambos menús
  [...desktopLinks, ...mobileLinks].forEach(link => {
    if (link.textContent.trim() === linkText) {
      link.classList.add('active');
    }
  });
}

// Función para inicializar referencias del menú
function initializeMenuReferences() {
  // Actualizar referencias
  menuToggle = document.getElementById("menu-toggle");
  navOverlay = document.getElementById("nav-overlay");
  closeMenu = document.getElementById("close-menu");

  if (menuToggle && navOverlay && closeMenu) {
    // Event listeners
    menuToggle.addEventListener("click", openMenu);
    closeMenu.addEventListener("click", closeMenuFunction);

    // Cerrar menú al hacer clic fuera del contenido
    navOverlay.addEventListener("click", function(event) {
      if (event.target === navOverlay) {
        closeMenuFunction();
      }
    });

    // Cerrar menú con la tecla Escape
    document.addEventListener("keydown", function(event) {
      if (event.key === "Escape" && navOverlay.classList.contains("show")) {
        closeMenuFunction();
      }
    });
  }
}

// Función principal de inicialización
function initializeNavigation() {
  // Inicializar referencias del menú
  initializeMenuReferences();

  // Establecer navegación activa basada en la página actual
  setActiveNavBasedOnCurrentPage();

  // Enlaces del menú desktop
  const desktopNavLinks = document.querySelectorAll('.navbar .nav-links a');
  desktopNavLinks.forEach(link => {
    link.addEventListener('click', function(e) {
      // Solo prevenir navegación si el href es "#" (enlace placeholder)
      if (this.getAttribute('href') === '#') {
        e.preventDefault();
      }
      setActiveNavItem(this);
    });
  });

  // Enlaces del menú móvil
  const mobileNavLinks = document.querySelectorAll('.nav-overlay .nav-links a');
  mobileNavLinks.forEach(link => {
    link.addEventListener('click', function(e) {
      // Solo prevenir navegación si el href es "#" (enlace placeholder)
      if (this.getAttribute('href') === '#') {
        e.preventDefault();
      }
      setActiveNavItem(this);
      closeMenuFunction(); // Cerrar menú móvil después de seleccionar
    });
  });

  // Cerrar menú al hacer clic en enlaces que no son de navegación (como Discord)
  const overlayLinks = document.querySelectorAll(".nav-overlay a:not(.nav-links a)");
  overlayLinks.forEach(link => {
    link.addEventListener("click", () => {
      closeMenuFunction();
    });
  });

  // Event listener para el scroll
  window.addEventListener('scroll', handleMenuScroll, { passive: true });
}

// Inicializar cuando el DOM esté listo
document.addEventListener('DOMContentLoaded', function() {
  initializeNavigation();
  initializeCurrencySelector();
});

// Reinicializar si se carga dinámicamente
if (document.readyState === 'loading') {
  document.addEventListener('DOMContentLoaded', function() {
    initializeNavigation();
    initializeCurrencySelector();
  });
} else {
  initializeNavigation();
  initializeCurrencySelector();
}
