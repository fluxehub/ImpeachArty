module.exports = {
  purge: [
    './src/**/*.html',
    './src/**/*.fs',
  ],
  darkMode: false, // or 'media' or 'class'
  theme: {
    fontFamily: {
      'sans': ['Manrope', 'Helvetica', 'Arial', 'sans-serif'],
    },
    extend: {
      colors: {
        'black-bg': '#222'
      }
    }
  },
  variants: {
    extend: {},
  },
  plugins: [],
}
